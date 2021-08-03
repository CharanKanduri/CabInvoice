﻿
using System;
using System.Collections.Generic;
using System.Text;


namespace CabInvoiceGenerate
{
    public class CabInvoiceCalculate
    {
        //Instance Variables
        double COST_PER_KM;
        int COST_PER_TIME;
        double MINIMUM_FARE;

       

        //Parameterised Constructor
        public CabInvoiceCalculate()
        {
            //Define values for Normal Ride

            
                COST_PER_KM = 10;
                COST_PER_TIME = 1;
                MINIMUM_FARE = 5;
            
            //Define values for Premium Ride
           
        }

        //Calculate Fare
        public double CalculateFare(double distance, int time)

        {
            double totalFare = 0;
            try
            {
                if (distance <= 0)
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_DISTANCE, "Distance should be Greater than zero");
                }
                if (time <= 0)
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_DISTANCE, "Time should be Greater than zero");
                }
                totalFare = distance * COST_PER_KM + time * COST_PER_TIME;
            }
            catch (CustomException message)
            {
                Console.WriteLine("Exception is: {0}", message.message);
            }
            return Math.Max(MINIMUM_FARE, totalFare);
        }
    }
}