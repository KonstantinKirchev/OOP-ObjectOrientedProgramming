namespace Exam.Core
{
    public static class GlobalMessages
    {
        #region Exception messages
        public const string StringCannotBeNullEmptyOrWhiteSpace = "{0} cannot be null, empty or white space!";
        public const string NumberCannotBeNegative = "{0} cannot be negative!";
        #endregion

        #region Error messages
        public const string InvalidCommand = "Invalid command!";
        public const string InvalidMilitantGroup = "Militant group with such a name \"{0}\" does not exists.";
        public const string InvalidWarEffectTriggering = "War effect cannot be triggered more than once.";
        #endregion
    }
}
