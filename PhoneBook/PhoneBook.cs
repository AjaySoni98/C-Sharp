using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace PhoneBook{
    public class Contacts{
        public string name;
        public long mobileNumber;
        public string emailId;

        public Contacts(string name, long mobileNumber, string emailId){
            this.name=name;
            this.mobileNumber=mobileNumber;
            this.emailId=emailId;
        }

        public string Name{
            get{
                return this.name;
            }
            set{
                this.name=value;
            }
        }

        public long MobileNumber{
            get{
                return this.mobileNumber;
            }
            set{
                if(Regex.Match(Convert.ToString(mobileNumber), @"^(\+[0-9]{9})$").Success){
                    this.mobileNumber=value;
                }else{
                    throw new InvalidMobileNumberException("Invalid Mobile Number.");
                }
            }
        }

        public string EmailId{
            get{
                return this.emailId;
            }
            set{
                if(Regex.Match(emailId, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success){
                    this.emailId=value;
                }else{
                    throw new InvalidEmailException("Invalid Email Id.");
                }
            }
        }

        public string toString(){
            return "Name: "+Name+", Mobile Number: "+MobileNumber+", Email Id: "+EmailId+".";
        }
    }

    public class InvalidMobileNumberException : Exception{
        public InvalidMobileNumberException(string message):base(message){}
    }

    public class InvalidEmailException : Exception{
        public InvalidEmailException(string message):base(message){}
    }

    public class SomeException : Exception{
        public SomeException(string message):base(message){}
    }

    public class ContactService{
        public static Contacts[] SIM = new Contacts[10];
        public static Contacts[] Phone = new Contacts[10];
    }

    interface IContactService{
        public void insertContact(Contacts contacts, string memory);
        public void updateContact(Contacts contacts, string memory);
        public Contacts searchContact(long mobileNumber, string memory);
    }

    public class ContactServiceImpl : ContactService, IContactService{

        public int getCount(Contacts[] array){
            int count = 0;
                for(int i=0;i<10;i++){
                    try{
                        if(array[i]!=null){
                            count++;
                        }
                    }catch{
                        continue;
                    }
                    
                }
            return count;
        }

        public void insertContact(Contacts contact, string memory){
            if(memory=="SIM" && getCount(SIM)!=10){
                if(getCount(SIM)==0){
                    SIM[0]=contact;
                }
                else{
                    SIM[getCount(SIM)]=contact;
                }
            }else if(memory=="Phone" && getCount(Phone)!=10){
                if(getCount(Phone)==0){
                    Phone[0]=contact;
                }
                else{
                    Phone[getCount(Phone)]=contact;
                }
            }
        }

        public void updateContact(Contacts contact, string memory){
            string newName = contact.name;
            long newMobileNumber = contact.mobileNumber;
            string newEmailId = contact.emailId;
            if(memory=="SIM"){
                for(int i=0;i<getCount(SIM); i++){
                    if(SIM[i].name==newName || SIM[i].mobileNumber==newMobileNumber || SIM[i].emailId==newEmailId){
                        SIM[i]=contact;
                    }
                }
            }else if(memory=="Phone"){
                for(int i=0;i<getCount(Phone); i++){
                    if(Phone[i].name==newName || Phone[i].mobileNumber==newMobileNumber || Phone[i].emailId==newEmailId){
                        Phone[i]=contact;
                    }
                }
            }
        }

        public Contacts searchContact(string name, string memory){
            string newName = name;
            if(memory=="SIM"){
                for(int i=0;i<getCount(SIM); i++){
                    if(SIM[i].name==newName){
                        return SIM[i];
                    }
                }
            }else if(memory=="Phone"){
                for(int i=0;i<getCount(Phone); i++){
                    if(Phone[i].name==newName){
                        return Phone[i];
                    }
                }
            }
            return new Contacts("NA", 0000000000, "NA");
        }

        public Contacts searchContact(long mobileNumber, string memory){
            long newMobileNumber = mobileNumber;
            if(memory=="SIM"){
                for(int i=0;i<getCount(SIM); i++){
                    if(SIM[i].mobileNumber==newMobileNumber){
                        return SIM[i];
                    }
                }
            }else if(memory=="Phone"){
                for(int i=0;i<getCount(Phone); i++){
                    if(Phone[i].mobileNumber==newMobileNumber){
                        return Phone[i];
                    }
                }
            }
            return new Contacts("NA", 0000000000, "NA");
        }

        public void Display(){
            SIM = SIM.Where(x => x!=null).OrderBy(x => x.name).ToArray();
            Phone = Phone.Where(x => x!=null).OrderBy(x => x.name).ToArray();

            Console.WriteLine("----------Printing Contacts from SIM----------");
            for(int i=0;i<getCount(SIM);i++){
                Contacts contactObject = SIM[i];
                Console.WriteLine("{0}. Name: {1}, Mobile Number: {2}, Email Id: {3}", i+1, contactObject.name, contactObject.mobileNumber, contactObject.emailId);
            }
            Console.WriteLine();
            Console.WriteLine("----------Printing Contacts from Phone----------");
            for(int i=0;i<getCount(Phone);i++){
                Contacts contactObject = Phone[i];
                Console.WriteLine("{0}. Name: {1}, Mobile Number: {2}, Email Id: {3}", i+1, contactObject.name, contactObject.mobileNumber, contactObject.emailId);
            }
        }

        public void Copy(Contacts contact, string fromMemory, string toMemory){
            if(fromMemory=="SIM" && toMemory=="Phone"){
                if(getCount(Phone)!=10){
                    for(int i=0;i<getCount(SIM);i++){
                        if(SIM[i].name==contact.name && SIM[i].mobileNumber==contact.mobileNumber && SIM[i].emailId==contact.emailId){
                            Phone[getCount(Phone)]=contact;
                        }
                    }
                }
            }else if(fromMemory=="Phone" && toMemory=="SIM"){
                if(getCount(SIM)!=10){
                    for(int i=0;i<getCount(Phone);i++){
                        if(Phone[i].name==contact.name && Phone[i].mobileNumber==contact.mobileNumber && Phone[i].emailId==contact.emailId){
                            SIM[getCount(SIM)]=contact;
                        }
                    }
                }
            }
        }

        public void CopyAll(string fromMemory, string toMemory){
            if(toMemory=="SIM" && (10-getCount(SIM))>=(10-getCount(Phone))){
                for(int i=0;i<getCount(Phone);i++){
                    SIM[getCount(SIM)]=Phone[i];
                }
            }else if(toMemory=="Phone" && (10-getCount(Phone))>=(10-getCount(SIM))){
                for(int i=0;i<getCount(SIM);i++){
                    Phone[getCount(Phone)]=SIM[i];
                }
            }
        }
    }
}