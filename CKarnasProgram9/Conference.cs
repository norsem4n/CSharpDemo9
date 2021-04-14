/* CIS 605 Homework 4 - Program 9
 * Created:             October 2020
 * Last Modified:       10.18.20
 * Developed by:        Christopher Karnas
 * Class name:          Conference
 * Description:         Cost of conference services for CSU
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram9
{

    #region "Enumeration"
    public enum AccommodationType
    {
        // set enumeration constants 

        Single = 1,
        Double = 2,
        Suite = 3
    }

    #endregion
    class Conference
    {
        #region "Constants"

        // given constants 

        const decimal singleRoom = 61.03m;
        const decimal doubleRoom = 39.59m;
        const decimal suiteRoom = 73.45m;
        const decimal internetCharge = 6.12m;
        const decimal recCharge = 5.37m;
        const decimal accommodationDiscount = 0.10m;
        const int minimumAttendeeDiscount = 50;
        const int minimumNightDiscount = 7;
        const decimal optionalServicesDiscount = 0.05m;

        #endregion

        #region "Fields"

        // provide fields

        private AccommodationType accommodationChoice;
        private int numberOfAttendees, numberOfNights;
        private bool internetAccess, recAccess;

        #endregion

        #region "Properties"

        // instance properties with values and set accessors 

        public string ConferenceName { get; set; }
        public decimal AccommodationCharge { get; private set; }
        public decimal OptionalServices { get; private set; }
        public decimal Discount { get; private set; }
        public decimal TotalCharge { get; private set; }

        public int NumberOfAttendees { get { return numberOfAttendees; } set { numberOfAttendees = value; CalculateConferenceCharges(); }}
        public int NumberOfNights { get { return numberOfNights; } set { numberOfNights = value; CalculateConferenceCharges(); }}
        public bool InternetAccess { get { return internetAccess; } set { internetAccess = value; CalculateConferenceCharges(); }}
        public bool RecAccess { get { return recAccess; } set { recAccess = value; CalculateConferenceCharges(); }}
        public AccommodationType AccommodationChoice { get { return accommodationChoice; } set { accommodationChoice = value; CalculateConferenceCharges(); }}
        #endregion

        #region "Constructor"

        // instantiate object and set properties

        public Conference(string nameOfConference, int numberOfAttendees, int numberOfNights, AccommodationType accommodationChoice, bool internetAccess, bool recAccess)
        {
            ConferenceName = nameOfConference;
            NumberOfAttendees = numberOfAttendees;
            NumberOfNights = numberOfNights;
            AccommodationChoice = accommodationChoice;
            InternetAccess = internetAccess;
            RecAccess = recAccess;
        }
        #endregion

        #region "Methods"

        // return the rate for the accommodation type
        private decimal CalculateAccommodationRate()
        {
            decimal accommodationChoice = 0;

            switch (AccommodationChoice)
            {
                case AccommodationType.Single: 
                    accommodationChoice = singleRoom;
                    break;
                case AccommodationType.Double: 
                    accommodationChoice = doubleRoom;
                    break;
                case AccommodationType.Suite: 
                    accommodationChoice = suiteRoom;
                    break;
            }
            return accommodationChoice;
        }


        // calculate conference charges method
        private void CalculateConferenceCharges()
        {
            //accommodation charge = accommodation type rate (determined by calling the previous instance method) *number of attendees *number of nights

            AccommodationCharge = CalculateAccommodationRate() * NumberOfAttendees * NumberOfNights;

            //optional services charge = Internet access charge + recreation center access charge

            decimal InternetAccessCharge = 0;
            decimal RecAccessCharge = 0;

            if (InternetAccess == true)
            {
                InternetAccessCharge = internetCharge * NumberOfAttendees * NumberOfNights;
            }

            if (RecAccess == true)
            {
                RecAccessCharge = recCharge * NumberOfAttendees * NumberOfNights;
            }

            OptionalServices = InternetAccessCharge + RecAccessCharge;

            //determine if a discount should apply

            if (NumberOfAttendees >= minimumAttendeeDiscount && NumberOfNights >= minimumNightDiscount)
            {
                Discount = (AccommodationCharge * accommodationDiscount) + (AccommodationCharge * optionalServicesDiscount);
            }
            else
            {
                Discount = 0;
            }
            
            // total charge for the conference

            TotalCharge = AccommodationCharge + OptionalServices - Discount;
        }

        #endregion

    }
}
