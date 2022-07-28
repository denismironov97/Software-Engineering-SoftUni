using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab._07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuestsInvites = new HashSet<string>();
            HashSet<string> regularGuestsInvites = new HashSet<string>();
            Regex regex = new Regex(@"(?<Vip>\d{1}\w{7})|(?<Guest>\w{8})");

            while (true)
            {
                string reservationInvites = Console.ReadLine();

                if (regex.IsMatch(reservationInvites))
                {
                    if (regex.Match(reservationInvites).Groups["Vip"].Success)
                    {
                        string vipReservation = regex.Match(reservationInvites).Groups["Vip"].Value;
                        vipGuestsInvites.Add(vipReservation);
                    }
                    else
                    {
                        string regularReservation = regex.Match(reservationInvites).Groups["Guest"].Value;
                        regularGuestsInvites.Add(regularReservation);
                    }
                }
                else if (reservationInvites == "PARTY")
                {
                    string actuallyPresentGuests = Console.ReadLine();

                    while (actuallyPresentGuests != "END")
                    {
                        vipGuestsInvites.Remove(actuallyPresentGuests);
                        regularGuestsInvites.Remove(actuallyPresentGuests);
                        actuallyPresentGuests = Console.ReadLine();
                    }

                    break;
                }
            }

            Console.WriteLine(vipGuestsInvites.Count + regularGuestsInvites.Count);

            foreach (string vips in vipGuestsInvites) //printing out the vips who did not came to the event
            {
                Console.WriteLine(vips);
            }

            foreach (string regulars in regularGuestsInvites) //printing out the regulars who did not came to the event
            {
                Console.WriteLine(regulars);
            }
        }
    }
}
