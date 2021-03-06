using System;
using System.Collections.Generic;

namespace DataFlow.EdFi.Models.EnrollmentComposite 
{
    public class Staff 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a staff.
        /// </summary>
        public string staffUniqueId { get; set; }

        /// <summary>
        /// A prefix used to denote the title, degree, position, or seniority of the person.
        /// </summary>
        public string personalTitlePrefix { get; set; }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        public string lastSurname { get; set; }

        /// <summary>
        /// The login ID for the user; used for security access control interface.
        /// </summary>
        public string loginId { get; set; }

        /// <summary>
        /// A person''s gender.
        /// </summary>
        public string sexType { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual was born.
        /// </summary>
        public DateTime? birthDate { get; set; }

        /// <summary>
        /// An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, "Spanish origin," can be used in addition to "Hispanic or Latino."
        /// </summary>
        public bool? hispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// An unordered collection of staffAddresses.  
        /// </summary>
        public List<Staff_staffAddress> addresses { get; set; }

        /// <summary>
        /// An unordered collection of staffElectronicMails.  
        /// </summary>
        public List<Staff_staffElectronicMail> electronicMails { get; set; }

        /// <summary>
        /// An unordered collection of staffIdentificationCodes.  
        /// </summary>
        public List<Staff_staffIdentificationCode> identificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of staffLanguages.  
        /// </summary>
        public List<Staff_staffLanguage> languages { get; set; }

        /// <summary>
        /// An unordered collection of staffRaces.  
        /// </summary>
        public List<Staff_staffRace> races { get; set; }

        /// <summary>
        /// An unordered collection of staffTelephones.  
        /// </summary>
        public List<Staff_staffTelephone> telephones { get; set; }

        /// <summary>
        /// An unordered collection of staffEducationOrganizationAssignmentAssociations.  
        /// </summary>
        public List<Staff_staffEducationOrganizationAssignmentAssociation> classifications { get; set; }

        }
}

