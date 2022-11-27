namespace WUC
{       
    internal class Calculator
    {
       public double wastewaterCost(double Water_Used, string Usertype)// calculate waste water cost


        {
            string domestic = "Domestic";
            string commercial = "Commercial";
            
            if (Usertype == domestic)
            {

                if (Water_Used <= 5)
                {
                    double waste_water_cost = (Water_Used * 0.65);
                    return waste_water_cost;
                }


                if (Water_Used > 5 && Water_Used <= 15)
                {
                    double waste_water_cost = Math.Round(((5 * 0.65) + ((Water_Used - 5) * 3.36)), 2);
                    return waste_water_cost;
                }

                if (Water_Used > 15 && Water_Used <= 25)
                {
                    double waste_water_cost = Math.Round(((5 * 0.65) + (10 * 3.36) + ((Water_Used - 15) * 5.03)), 2);
                    return waste_water_cost;
                }


                if (Water_Used > 25 && Water_Used <= 40)
                {
                    double waste_water_cost = Math.Round(((5 * 0.65) + (10 * 3.36) + (10 * 5.03) + ((Water_Used - 25) * 6.71)), 2);
                    return waste_water_cost;
                }

                else
                {
                    double waste_water_cost = Math.Round(((5 * 0.65) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + ((Water_Used - 40) * 8.39)), 2);
                    return waste_water_cost;
                }
            }

            if (Usertype == commercial)
            {
                if (Water_Used <= 5)
                {
                    double waste_water_cost = Math.Round((Water_Used * 0.74), 2);
                    return waste_water_cost;
                }

                if (Water_Used > 5 && Water_Used <= 15)
                {
                    double waste_water_cost = Math.Round(((5 * 0.74) + ((Water_Used - 5) * 3.36)), 2);
                    return waste_water_cost;
                }

                if (Water_Used > 15 && Water_Used <= 25)
                {
                    double waste_water_cost = Math.Round(((5 * 0.74) + (10 * 3.36) + ((Water_Used - 15) * 5.03)), 2);
                    return waste_water_cost;
                }
                if (Water_Used > 25 && Water_Used <= 40)
                {
                    double waste_water_cost = Math.Round(((5 * 0.74) + (10 * 3.36) + (10 * 5.03) + ((Water_Used - 25) * 6.71)), 2);
                    return waste_water_cost;

                }
                else
                {
                    double waste_water_cost = Math.Round(((5 * 0.74) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + ((Water_Used - 40) * 8.39)), 2);
                    return waste_water_cost;

                }

            }

            else
            {
                return 0;
            }

        }






        public double PortableWaterCost(double Water_Used, string Usertype)//calculate portable water cost
        {
            string domestic = "Domestic";
            string commercial = "Commercial";
            if (Usertype == domestic)
            {
                if (Water_Used <= 5)
                {
                    double portable_Water_Cost = (Water_Used * 3.60);
                    return portable_Water_Cost;
                }
                if (Water_Used > 5 && Water_Used <= 15)
                {
                    double portable_Water_Cost = Math.Round(((5 * 3.60) + ((Water_Used - 5) * 13.43)), 2);
                    return portable_Water_Cost;
                }
                if (Water_Used > 15 && Water_Used <= 25)
                {
                    double portable_Water_Cost = Math.Round(((5 * 3.60) + (10 * 13.43) + ((Water_Used - 15) * 23.51)), 2);
                    return portable_Water_Cost;
                }
                if (Water_Used > 25 && Water_Used <= 40)
                {
                    double portable_Water_Cost = Math.Round(((5 * 3.60) + (10 * 13.43) + (10 * 23.51) + ((Water_Used - 25) * 36.16)), 2);
                    return portable_Water_Cost;
                }
                else
                {
                    double portable_Water_Cost = Math.Round(((5 * 3.60) + (10 * 13.43) + (10 * 23.51) + (15 * 36.16) + ((Water_Used - 40) * 45.21)), 2);
                    return portable_Water_Cost;
                }
            }

            if (Usertype == commercial)
            {
                if (Water_Used <= 5)
                {
                    double portable_Water_Cost = Math.Round((Water_Used * 4.92), 2);
                    return portable_Water_Cost;
                }
                if (Water_Used > 5 && Water_Used <= 15)
                {
                    double portable_Water_Cost = Math.Round(((5 * 4.92) + ((Water_Used - 5) * 14.61)), 2);
                    return portable_Water_Cost;
                }
                if (Water_Used > 15 && Water_Used <= 25)
                {
                    double portable_Water_Cost = Math.Round(((5 * 4.92) + (10 * 14.61) + ((Water_Used - 15) * 25.58)), 2);
                    return portable_Water_Cost;
                }
                if (Water_Used > 25 && Water_Used <= 40)
                {
                    double portable_Water_Cost = Math.Round(((5 * 4.92) + (10 * 14.61) + (10 * 25.58) + ((Water_Used - 25) * 39.35)), 2);
                    return portable_Water_Cost;
                }
                else
                {
                    double portable_Water_Cost = Math.Round(((5 * 4.92) + (10 * 14.61) + (10 * 25.58) + (15 * 39.35) + ((Water_Used - 40) * 49.20)), 2);
                    return portable_Water_Cost;
                }
            }
            else
            {
                return 0;
            }

        }





        public double getbill(double Water_Used, string Usertype)
        {

            Calculator calculator = new Calculator();
            double total_amount =Math.Round(calculator.PortableWaterCost(Water_Used, Usertype) + calculator.wastewaterCost(Water_Used, Usertype),2);
            return total_amount;
        }

    }
}