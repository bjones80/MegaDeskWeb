using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDeskWeb
{
    public class DeskQuote
    {
        const decimal BASE_PRICE = 200;
        public Desk Desk { get; set; }
        public decimal RushDays { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal ShippingCost { get; set; }

        public decimal DeskPrice { get; set; }


        //
        // create new deskQuote from addQuote variables
        //
        //public DeskQuote(Desk deskCopy, decimal days, string name)
        //{
        //    this.newDesk = deskCopy;
        //    this.rushDays = days;
        //    this.customerName = name;
        //    this.quoteDate = DateTime.Now;
        //    decimal area = newDesk.surfaceArea();
        //    this.shippingCost = calcshippingCost(rushDays,area);
        //    decimal materialCost = calcMaterialCost(newDesk.surfaceMaterial);
        //    this.deskPrice = calcDeskPrice(materialCost, area, this.shippingCost);
        //}
        
        //
        // Prices from rushOrderPrices.txt will go here
        //
        List<decimal> shippingPriceList = new List<decimal>();

        int[,] shippingPriceArray = new int[3, 3];

        //
        // Create [,]Array for shipping cost 
        //
        public int[,] CreateShippingArray()
        {
            StreamReader fileName = new StreamReader("rushOrderPrices.txt");
            try
            {
                while (fileName.EndOfStream == false)
                {
                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            string line = fileName.ReadLine();
                            shippingPriceArray[row, col] = int.Parse(line);
                        }
                    }
                }
                fileName.Close();
            }
            catch (FileNotFoundException)
            {
               // System.Windows.Forms.MessageBox.Show("File " + fileName + " could not be found");
            }
            return shippingPriceArray;
        }

        //
        // Calculate Shipping Cost 
        //
        public decimal calcshippingCost(decimal pvRushDays, decimal pvArea)
        {

            decimal shippingPrice;
            CreateShippingArray();

            if (pvRushDays == 3)
            {
                if (pvArea < 1000)
                {
                    shippingPrice = shippingPriceArray[0, 0];
                }
                else if (pvArea < 2001)
                {
                    shippingPrice = shippingPriceArray[0, 1];
                }
                else
                {
                    shippingPrice = shippingPriceArray[0, 2];
                }
            }
            else if (pvRushDays == 5)
            {
                if (pvArea < 1000)
                {
                    shippingPrice = shippingPriceArray[1, 0];
                }
                else if (pvArea < 2001)
                {
                    shippingPrice = shippingPriceArray[1, 1];
                }
                else
                {
                    shippingPrice = shippingPriceArray[1, 2];
                }
            }
            else
            {
                if (pvArea < 1000)
                {
                    shippingPrice = shippingPriceArray[2, 0];
                }
                else if (pvArea < 2001)
                {
                    shippingPrice = shippingPriceArray[2, 1];
                }
                else
                {
                    shippingPrice = shippingPriceArray[2, 2];
                }
            }
            return shippingPrice;

        }

        //
        // calculate cost of matieral 
        //
        public decimal CalcMaterialCost(int pvMateralId)
        {
            decimal materialPrice;
            switch (pvMateralId)
            {              
                case 1:
                    materialPrice = 200;
                    break;
                case 2:
                    materialPrice = 100;
                    break;
                case 3:
                    materialPrice = 50;
                    break;
                case 4:
                    materialPrice = 300;
                    break;
                default:
                    materialPrice = 125;
                    break;

            }
            return materialPrice;
        }
        //
        // Calculate the cost of the desk
        //
        public decimal CalcDeskPrice(decimal pvMaterialCost, decimal pvArea, decimal pvShippingCost)
        {
            if (pvArea < 1000)
                return BASE_PRICE + pvShippingCost + pvMaterialCost;
            else
                return BASE_PRICE + pvShippingCost + pvMaterialCost + pvArea;

            
        }
    }


}

