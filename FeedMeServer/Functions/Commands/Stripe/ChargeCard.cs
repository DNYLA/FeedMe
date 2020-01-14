using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeedMeNetworking.Serialization;
using Stripe;

namespace FeedMeServer.Functions.Commands.Stripe
{
   class ChargeCard
    {
        public static string PubKey = "pk_test_YQJKZKyYgy5Yxcm5xRS9SNtx00S8lExmz2"; //Public Key
        public static string SecretKey = "sk_test_hUXfz1JlyFizkc5aYs1RQEXs00IcYtIlfB"; //Secret Key

        /// <summary>
        /// Charged the card Using STRIPE API
        /// </summary>
        /// <param name="OI"></param>
        /// <returns>0: Success 1: Invalid Card 2: Undiagnosed Error</returns>
        public static bool CheckCard(OrderInfo OI)
        {
            /*
                * Using Stripe's library to make request
                * Everything below is from the Official Documentation
                * From https://stripe.com/docs/api
                *
                */

            //Set To public key so we can create a Card Card Object
            StripeConfiguration.ApiKey = PubKey;

            //Getting Card & Price Information // No Error Checks added so it can crash the program

            string CardNo = OI.Card.CardNum;
            CardNo = "4242 4242 4242 4242";
            string CVCText = OI.Card.CVC;
            CVCText = "198";
            string UserEmail = "Dan@Gmail.com";
            string DescriptionText = "Tes It is";

            //Creating A Token to "Build" the card.
            var TokenOptions = new TokenCreateOptions
            {
                Card = new CreditCardOptions //Card Object
                {
                    Number = CardNo,
                    ExpYear = 25,
                    ExpMonth = 12,
                    Cvc = CVCText
                }
            };

            //Creating a Token and attaching Card Object
            var Tokenservice = new TokenService();
            Token stripeToken = Tokenservice.Create(TokenOptions);

            //Set To Private key to tell API that we are Charging.
            StripeConfiguration.ApiKey = SecretKey;

            //Ive Tried to add as much Paramters into the ChargeOptions as incase you find something useful. The Only Things you Require is Amount, Currency and Source.
            var ChargeOptions = new ChargeCreateOptions
            {
                Amount = Convert.ToInt64(OI.TotalPrice * 100),
                Currency = "gbp",
                ReceiptEmail = UserEmail,
                Description = DescriptionText,
                //Metadata = MetadataToAdd,
                Source = "tok_mastercard" //obtained with Stripe.js
            };
            try
            {
                //Creating a Service To Charge the Card
                var ChargeService = new ChargeService();
                Charge charge = ChargeService.Create(ChargeOptions);
                return true;
            }
            catch (StripeException ex)
            {
                Console.WriteLine(ex.Message);
                //Switch Statement is from API Documentation
                //Shows Each Invidivual Error which i can edit if i want to return specific errors.
                switch (ex.StripeError.ErrorType)
                {
                    case "card_error":
                        //MessageBox.Show("Code: " + ex.StripeError.Code);
                        //MessageBox.Show("Message: " + ex.StripeError.Message);
                    case "api_connection_error":
                        break;
                    case "api_error":
                        break;
                    case "authentication_error":
                        break;
                    case "invalid_request_error":
                        break;
                    case "rate_limit_error":
                        break;
                    case "validation_error":
                        break;
                    default:
                        // Unknown Error Type
                        break;
                }
                return false;
            }
        }
    }
}
