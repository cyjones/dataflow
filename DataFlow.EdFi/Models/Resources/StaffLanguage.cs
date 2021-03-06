using System.Collections.Generic;

namespace DataFlow.EdFi.Models.Resources 
{
    public class StaffLanguage 
    {
        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string languageDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of staffLanguageUses.  A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        public List<StaffLanguageUse> uses { get; set; }

        }
}

