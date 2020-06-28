using System;

namespace C__Case_Study__Requirement_2{
    public class Product{
        public string productCode;
        public string productName;
        public double productPrice;
        public char categoryCode;

        public Product(){}
        
        public Product(string PCode, string Name, double Price, char Code){
            this.productCode=PCode;
            this.productName=Name;
            this.productPrice=Price;
            this.categoryCode=Code;
        }
        
        public string PrintProduct(){
            return "Code-"+productCode+System.Environment.NewLine+System.Environment.NewLine+"Name – "+productName+System.Environment.NewLine+System.Environment.NewLine+"Price - "+productPrice+System.Environment.NewLine+System.Environment.NewLine+"Category – "+categoryCode;
        }
        
        public string ReadProductDetails(string s1, string s2){
            string[] first=s1.Split(',');
            string[] second=s2.Split(',');
            Product p1 = new Product(first[0], first[1], Convert.ToDouble(first[2]), char.Parse(first[3]));
            Product p2 = new Product(second[0], second[1], Convert.ToDouble(second[2]), char.Parse(second[3]));
            if (p1.productName.ToLower()==p2.productName.ToLower() && p1.productCode==p2.productCode){
                return "Product 1 is same as Product 2";
            }else{
                return "Product 1 and Product 2 are different";
            }
        }
    }
}