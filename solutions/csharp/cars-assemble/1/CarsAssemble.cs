static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            double rate;
            if(speed == 0) 
            {
                rate = 0.0;
            }
            else if (speed>= 1 && speed <= 4)
            {
                rate = 1.0;
            }
            else if(speed >= 5 && speed <= 8)
            {
                rate = 0.9;
            }
            else if (speed == 10)
            {
                rate = 0.77;
            }
            else if (speed == 9)
            {
                rate = 0.8;
            }
            else
            {
                Console.WriteLine("Invalid number");
                return rate = 0.000000000000000000000;
            }

            return rate;
        }

        public static double ProductionRatePerHour(int speed)
        {

            int prod = speed * 221;

            double ans = prod * SuccessRate(speed);

            return ans;
        }

        public static int WorkingItemsPerMinute(int speed)
        {
            int production = Convert.ToInt32(ProductionRatePerHour(speed));

            return production / 60;
        }
    }