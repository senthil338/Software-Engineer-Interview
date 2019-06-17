using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DesignPattern.Adapter
{
   
public class AdapterPattern
    {

        /* 
         *  Adpter pattern Fall under Structural Patterns
         *  Client -> Interface -> Adaptee
         *  Client -> Interface <-> Adapter <-> Adaptee
         *  Problem Statement:
                The website allows users to shop and pay online. The site
                is integrated with a 3rd party payment gateway, through which users can pay their bills 
                using their credit card. Everything was going well, until his manager called him for a 
                change in the project.
         *  
         */  

        public interface IEpay
        {
            String getCreditCardNo();
            String getCustomerName();
            String getCardExpMonth();
            String getCardExpYear();
            short getCardCVVNo();
            Double getAmount();
            void setCreditCardNo(String creditCardNo);
            void setCustomerName(String customerName);
            void setCardExpMonth(String cardExpMonth);
            void setCardExpYear(String cardExpYear);
            void setCardCVVNo(short cardCVVNo);
            void setAmount(Double amount);
        }

        public class Epay : IEpay
        {
            private String creditCardNo;
            private String customerName;
            private String cardExpMonth;
            private String cardExpYear;
            private short cardCVVNo;
            private Double amount;
            public String getCreditCardNo() => creditCardNo;
            public String getCustomerName() => customerName;
            public String getCardExpMonth() => cardExpMonth;
            public String getCardExpYear() => cardExpYear;
            public short getCardCVVNo() => cardCVVNo;
            public Double getAmount() => amount;
            public void setCreditCardNo(String creditCardNo) => this.creditCardNo = creditCardNo;
            public void setCustomerName(String customerName) => this.customerName = customerName;
            public void setCardExpMonth(String cardExpMonth) => this.cardExpMonth = cardExpMonth;
            public void setCardExpYear(String cardExpYear) => this.cardExpYear = cardExpYear;
            public void setCardCVVNo(short cardCVVNo) => this.cardCVVNo = cardCVVNo;
            public void setAmount(double amount) => this.amount = amount;

        }
        public static void main(string[] args)
        {
            IEpay ePay = new Epay();
            ePay.setCreditCardNo("4789565874102365");
            ePay.setCustomerName("Sachin Tendulkar");
            ePay.setCardExpMonth("09");
            ePay.setCardExpYear("25");
            ePay.setCardCVVNo((short)235);
            ePay.setAmount(2565.23);
            
            #region "Adapter"
            PayD payD = new XpayToPayDAdapter(ePay);
            payD.getCardOwnerName();
            payD.getCardExpMonthDate();
            #endregion
        }

        #region PaymenD
        public interface PayD
        {
            String getCustCardNo();
            String getCardOwnerName();
            String getCardExpMonthDate();
            int getCVVNo();
            Double getTotalAmount();
            void setCustCardNo(String custCardNo);
            void setCardOwnerName(String cardOwnerName);
            void setCardExpMonthDate(String cardExpMonthDate);
            void setCVVNo(int cVVNo);
            void setTotalAmount(Double totalAmount);
        }
        #endregion

        #region Adapter
        public class XpayToPayDAdapter: PayD
        {
        private String custCardNo;
        private String cardOwnerName;
        private String cardExpMonthDate;
        private int cVVNo;
        private Double totalAmount;
        private IEpay epay;
            public XpayToPayDAdapter(IEpay _epay)
            {
                this.epay = _epay;
                setProp();
            }
            public String getCustCardNo() => custCardNo;
            public String getCardOwnerName() => cardOwnerName;
            public String getCardExpMonthDate() => cardExpMonthDate;
            public int getCVVNo() => cVVNo;
            public Double getTotalAmount() => totalAmount;
            public void setCustCardNo(String custCardNo) => this.custCardNo = custCardNo;
            public void setCardOwnerName(String cardOwnerName) => this.cardOwnerName = cardOwnerName;
            public void setCardExpMonthDate(String cardExpMonthDate) => this.cardExpMonthDate = cardExpMonthDate;
            public void setCVVNo(int cVVNo) => this.cVVNo = cVVNo;
            public void setTotalAmount(Double totalAmount) => this.totalAmount = totalAmount;
    
        private void setProp()
        {
            setCardOwnerName(this.epay.getCustomerName());
            setCustCardNo(this.epay.getCreditCardNo());
            setCardExpMonthDate(this.epay.getCardExpMonth() + "/" + this.epay.getCardExpYear());
            setCVVNo(this.epay.getCardCVVNo());
            setTotalAmount(this.epay.getAmount());
        }
    }
    #endregion
}
}
