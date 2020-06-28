using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace C__Case_Study__Requirement_1{
	public class Product
	{
	//Write your code here   
        private string productCode,productName;
        private double productPrice;
        private char categoryCode;
        private static int prodCounter = 100;
        
        public string ProductCode{
            get{
                return this.productCode;
            }
            set{
                this.productCode = value;
            }
        }
        public string ProductName{
            get{
                return this.productName;
            }
            set{
                this.productName = value;
            }
        }
        public double ProductPrice{
            get{
                return this.productPrice;
            }
            set{
                this.productPrice = value;
            }
        }
        public char CategoryCode{
            get{
                return this.CategoryCode;
            }
            set{
                this.categoryCode = value;
            }
        }
        
        private string generateProductCode(){
            prodCounter+=1;
            productCode = Convert.ToString(prodCounter) + categoryCode;
            return productCode;
        }
        
        public Product(string name,double price,char ccode){
            productName = name;
            productPrice = price;
            categoryCode = ccode;
            productCode = generateProductCode();
        }
        public Product(string name,double price){
            productName = name;
            productPrice = price;
            categoryCode = 'E';
            productCode = generateProductCode();
        }
        public string getProductDetails(){
            string productDetails = "Code–"+ProductCode+", Name – "+ProductName+" ,Price - "+productPrice+", Category – "+categoryCode;
            return productDetails; 
        }
    }
}