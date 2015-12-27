namespace Exam.Core
{
    using System;
    using System.Linq;

    using Exceptions;
    using Factories.Interfaces;
    using Models.Enums;
    using Models.Interfaces;

    using Interfaces;

    public class Engine : IEngine
    {
        private int dayCounter = 0;
        private int triggerCounter = 0;
        private int warEffectCounter = 0;

        private IMilitantGroup attackerGroup = null;
        private IMilitantGroup targetGroup = null;

        private bool isTriggered = false;
        private int initHealthAttacker = 0;
        private int initHealthTarget = 0;

        private readonly IMilitantGroupFactory militantGroupFactory;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;
        private readonly IIsisData data;

        public Engine(IMilitantGroupFactory militantGroupFactory, IInputReader reader, IOutputWriter writer, IIsisData data)
        {
            this.militantGroupFactory = militantGroupFactory;
            this.reader = reader;
            this.writer = writer;
            this.data = data;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split(new string[] { ".", ", ", ")", "(" }, StringSplitOptions.RemoveEmptyEntries);

                this.dayCounter++;
                this.ExecuteCommand(input);
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[1])
            {
                case EngineCommands.CreateMilitantGroupCommand:
                    this.ExecuteCreateCommand(inputParams);
                    break;
                case EngineCommands.AttackCommand:
                    this.ExecuteAttackCommand(inputParams);
                    break;
                case EngineCommands.SkipCommand:
                    break;
                case EngineCommands.StatusCommand:
                    this.ExecuteStatusCommand();
                    break;
                case EngineCommands.EndCommand:
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException(GlobalMessages.InvalidCommand);
            }
        }

        private void ExecuteStatusCommand()
        {
            var sortedGroups = this.data.MilitantGroups
                .OrderByDescending(m => m.Health)
                .ThenByDescending(m => m.Damage);

            foreach (var militantGroup in sortedGroups)
            {
                this.writer.PrintLine(militantGroup.ToString());
            }
        }

        private void ExecuteAttackCommand(string[] inputParams)
        {
            this.triggerCounter++;

            var attackerName = inputParams[0];
            var targetName = inputParams[2];

            var attacker = this.data.MilitantGroups.FirstOrDefault(m => m.Name == attackerName);
            this.attackerGroup = attacker;

            if (attacker == null)
            {
                throw new MilitantGroupException(string.Format(GlobalMessages.InvalidMilitantGroup, attackerName));
            }

            var target = this.data.MilitantGroups.FirstOrDefault(m => m.Name == targetName);
            this.targetGroup = target;

            if (target == null)
            {
                throw new MilitantGroupException(string.Format(GlobalMessages.InvalidMilitantGroup, targetName));
            }

            this.ProcessBattle(attacker, target);

        }

        private void ProcessBattle(IMilitantGroup attacker, IMilitantGroup target)
        {
            this.warEffectCounter++;
            if (this.isTriggered)
            {
                if (attacker.WarEffect == WarEffect.Jihad)
                {
                    attacker.Damage -= 5;
                }
                else if (attacker.WarEffect == WarEffect.Kamikaze)
                {
                    attacker.Health -= 10;
                }

                if (attacker.Health < 0)
                {
                    attacker.Health = 0;
                }

            }

            if (this.triggerCounter == 1)
            {
                this.initHealthAttacker = attacker.Health;
                this.initHealthTarget = target.Health;
            }

            if (target.Health <= (this.initHealthTarget / 2))
            {
                this.isTriggered = true;
                this.warEffectCounter++;
            }

            if (this.warEffectCounter == 1)
            {
                if (attacker.WarEffect == WarEffect.Jihad)
                {
                    attacker.Damage *= 2;
                }
                else if (attacker.WarEffect == WarEffect.Kamikaze)
                {
                    attacker.Health += 50;
                }
            }

            if (attacker.AttackType == AttackType.Paris)
            {
                target.Health -= attacker.Damage;

                if (target.Health < 0)
                {
                    target.Health = 0;
                }
            }
            else if (attacker.AttackType == AttackType.SU24)
            {
                attacker.Health = (int)Math.Ceiling((double)attacker.Health / 2);

                if (attacker.Health <= (this.initHealthAttacker / 2))
                {
                    this.isTriggered = true;
                    this.warEffectCounter++;
                }

                if (attacker.Health < 1)
                {
                    throw new UnsufficiantHealthException("Health is critical. You cannot attack :(");
                }

                target.Health -= (attacker.Damage * 2);
            }

        }

        private void ExecuteCreateCommand(string[] inputParams)
        {
            var name = inputParams[0];
            var health = int.Parse(inputParams[2]);
            var damage = int.Parse(inputParams[3]);
            string effect = inputParams[4];
            string attack = inputParams[5];

            WarEffect warEffect = (WarEffect)Enum.Parse(typeof(WarEffect), effect);
            AttackType attackType = (AttackType)Enum.Parse(typeof(AttackType), attack);

            IMilitantGroup militantGroup =
                this.militantGroupFactory.CreateMilitantGroup(name, health, damage, warEffect, attackType);

            this.data.AddMilitantGroup(militantGroup);
        }
    }
}
