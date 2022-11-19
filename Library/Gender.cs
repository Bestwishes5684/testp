using System.ComponentModel;

namespace Library
{
    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мужской
        /// </summary>
        [Description("Мужской")]
        Male,
        /// <summary>
        /// Женский
        /// </summary>
        [Description("Female")]
        Female,
    }
}
