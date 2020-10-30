using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApplication1.DesignPattern.BuilderPattern.Builder;
using static ConsoleApplication1.DesignPattern.BuilderPattern.Builder2;

namespace ConsoleApplication1.DesignPattern.BuilderPattern
{
    #region Builder Patter example 1
    public class Builder
    {
        public class Car
        {
            private String bodyStyle;
            private String power;
            private String engine;
            private String breaks;
            private String seats;
            private String windows;
            private String fuelType;
            private String carType;
            public Car(String carType)
            {
                this.carType = carType;
            }
            public String getBodyStyle()
            {
                return bodyStyle;
            }
            public void setBodyStyle(String bodyStyle)
            {
                this.bodyStyle = bodyStyle;
            }
            public String getPower()
            {
                return power;
            }
            public void setPower(String power)
            {
                this.power = power;
            }
            public String getEngine()
            {
                return engine;
            }
            public void setEngine(String engine)
            {
                this.engine = engine;
            }
            public String getBreaks()
            {
                return breaks;
            }
            public void setBreaks(String breaks)
            {
                this.breaks = breaks;
            }
            public String getSeats()
            {
                return seats;
            }
            public void setSeats(String seats)
            {
                this.seats = seats;
            }
            public String getWindows()
            {
                return windows;
            }
            public void setWindows(String windows)
            {
                this.windows = windows;
            }
            public String getFuelType()
            {
                return fuelType;
            }
            public void setFuelType(String fuelType)
            {
                this.fuelType = fuelType;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("--------------" + carType + "--------------------- \\n");
                sb.Append(" Body: ");
                sb.Append(bodyStyle);
                sb.Append("\\n Power: ");
                sb.Append(power);
                sb.Append("\\n Engine: ");
                sb.Append(engine);
                sb.Append("\\n Breaks: ");
                sb.Append(breaks);
                sb.Append("\\n Seats: ");
                sb.Append(seats);
                sb.Append("\\n Windows: ");
                sb.Append(windows);
                sb.Append("\\n Fuel Type: ");
                sb.Append(fuelType);
                return sb.ToString();
            }

        }

        public interface CarBuilder
        {

            void buildBodyStyle();
            void buildPower();
            void buildEngine();
            void buildBreaks();
            void buildSeats();
            void buildWindows();
            void buildFuelType();
            Car getCar();
        }

        public class SedanCarBuilder : CarBuilder
        {
            private static Car car = new Car("SEDAN");
            public void buildBodyStyle()
            {
                car.setBodyStyle("External dimensions: overall length (inches): 202.9, " +
                "overall width (inches): 76.2, overall height (inches):  60.7, wheelbase(inches): 112.9, " +
                " front track (inches): 65.3, rear track (inches): 65.5 and  curb to curb turning circle(feet): 39.5");
            }

            public void buildBreaks()
            {
                car.setPower("285 hp @ 6,500 rpm; 253 ft lb of torque @ 4,000 rpm");
            }

            public void buildEngine()
            {
                car.setEngine("3.5L Duramax V 6 DOHC");
            }

            public void buildFuelType()
            {
                car.setFuelType("Gasoline 19 MPG city, 29 MPG highway, 23 MPG combined and 437 mi.range");
            }

            public void buildPower()
            {
                car.setPower("285 hp @ 6,500 rpm; 253 ft lb of torque @ 4,000 rpm");
            }

            public void buildSeats()
            {
                car.setSeats("Front seat center armrest.Rear seat center armrest.Split- folding rear seats");
            }

            public void buildWindows()
            {
                car.setWindows("Laminated side windows.Fixed rear window with defroster");
            }

            public Car getCar()
            {
                return car;
            }
        }

        public class SportsCarBuilder : CarBuilder
        {
            private static Car car = new Car("SPORTS");
            public void buildBodyStyle()
            {
                car.setBodyStyle("External dimensions: overall length (inches): 192.3," +
                " overall width (inches): 75.5, overall height (inches): 54.2, wheelbase(inches): 112.3, " +
                " front track (inches): 63.7, rear track (inches): 64.1 and curb to curb turning circle(feet): 37.7");
            }

            public void buildBreaks()
            {
                car.setBreaks("Four-wheel disc brakes: two ventilated. Electronic brake  distribution.StabiliTrak stability control");
            }

            public void buildEngine()
            {
                car.setEngine("3.6L V 6 DOHC and variable valve timing");
            }

            public void buildFuelType()
            {
                car.setFuelType("Gasoline 17 MPG city, 28 MPG highway, 20 MPG combined and  380 mi.range");
            }

            public void buildPower()
            {
                car.setPower("323 hp @ 6,800 rpm; 278 ft lb of torque @ 4,800 rpm");
            }

            public void buildSeats()
            {
                car.setSeats("Driver sports front seat with one power adjustments manual " +
                    "height, front passenger seat sports front seat with one power adjustments");
            }

            public void buildWindows()
            {
                car.setWindows("Front windows with one-touch on two windows");
            }

            public Car getCar()
            {
                return car;
            }
        }

        public class CarDirector
        {
            CarBuilder builder;
            public CarDirector(CarBuilder builder)
            {
                this.builder = builder;
            }
            public void Build()
            {
                builder.buildBodyStyle();
                builder.buildBreaks();
                builder.buildEngine();
                builder.buildFuelType();
                builder.buildPower();
                builder.buildSeats();
                builder.buildWindows();
            }
        }
        
    }
    #endregion

    public class ClientCallBuilder
    {
        public static void Main_1(string[] args)
        {
            CarBuilder carBuilder = new SedanCarBuilder();
            CarDirector director = new CarDirector(carBuilder);
            director.Build();
            Car car = carBuilder.getCar();

            carBuilder = new SportsCarBuilder();
            director = new CarDirector(carBuilder);
            director.Build();
            car = carBuilder.getCar();

            Form form = new Form.FormBuilder("Dave", "Carter", "DavCarter", "DAvCaEr123  - ").PasswordHint("MyName").City("NY").Language("English").build();

        }

     
    }
    #region Builder Patter example 2
    /*
     Instead of making the desired object directly, the client calls a constructor with all
        of the required parameters and gets a builder object. Then the client calls setter-like methods on the builder object to set each
        optional parameter of interest. Finally, the client calls a parameter less build method to generate the object.
     */
    public class Builder2
    {
        public class Form
        {
            private String firstName;
            private String lastName;
            private String userName;
            private String password;
            private String address;
            private DateTime dob;
            private String email;
            private String backupEmail;
            private String spouseName;
            private String city;
            private String state;
            private String country;
            private String language;
            private String passwordHint;
            private String securityQuestion;
            private String securityAnswer;
            public class FormBuilder
            {
                public String firstName;
                public String lastName;
                public String userName;
                public String password;
                public String address;
                public DateTime dob;
                public String email;
                public String backupEmail;
                public String spouseName;
                public String city;
                public String state;
                public String country;
                public String language;
                public String passwordHint;
                public String securityQuestion;
                public String securityAnswer;
                public FormBuilder(String _firstName, String _lastName, String _userName, String _password)
                {
                    firstName = _firstName;
                    lastName = _lastName;
                    userName = _userName;
                    password = _password;
                }
                public FormBuilder Address(String Address)
                {
                    address = Address;
                    return this;
                }
                public FormBuilder Dob(DateTime Dob)
                {
                    dob = Dob;
                    return this;
                }
                public FormBuilder Email(String Email)
                {
                    email = Email;
                    return this;
                }
                public FormBuilder BackupEmail(String BackupEmail)
                {
                    backupEmail = BackupEmail;
                    return this;
                }
                public FormBuilder SpouseName(String SpouseName)
                {
                    spouseName = SpouseName;
                    return this;
                }
                public FormBuilder City(String City)
                {
                    city = City;
                    return this;
                }
                public FormBuilder State(String State)
                {
                  state = State;
                    return this;
                }
                public FormBuilder Country(String Country)
                {
                    country = Country;
                    return this;
                }
                public FormBuilder Language(String Language)
                {
                    language = Language;
                    return this;
                }
                public FormBuilder PasswordHint(String PasswordHint)
                {
                    passwordHint = PasswordHint;
                    return this;
                }
                public FormBuilder SecurityQuestion(String SecurityQuestion)
                {
                    securityQuestion = SecurityQuestion;
                    return this;
                }
                public FormBuilder SecurityAnswer(String SecurityAnswer)
                {
                    securityAnswer = SecurityAnswer;
                    return this;
                }
                public Form build()
                {
                    return new Form(this);
                }
            }
            private Form(FormBuilder formBuilder)
            {

                firstName = formBuilder.firstName;
                lastName = formBuilder.lastName;
                userName = formBuilder.userName;
                password = formBuilder.password;
                address = formBuilder.address;
                dob = formBuilder.dob;
                email = formBuilder.email;
                backupEmail = formBuilder.backupEmail;
                spouseName = formBuilder.spouseName;
                city = formBuilder.city;
                state = formBuilder.state;
                country = formBuilder.country;
                language = formBuilder.language;
                passwordHint = formBuilder.passwordHint;
                securityQuestion = formBuilder.securityQuestion;
                securityAnswer = formBuilder.securityAnswer;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" First Name: ");
                sb.Append(firstName);
                sb.Append("\\n Last Name: ");
                sb.Append(lastName);
                sb.Append("\\n User Name: ");
                sb.Append(userName);
                sb.Append("\\n Password: ");
                sb.Append(password);
                if (this.address != null)
                {
                    sb.Append("\\n Address: ");
                    sb.Append(address);
                }
                if (this.dob != null)
                {
                    sb.Append("\\n DOB: ");
                    sb.Append(dob);
                }
                if (this.email != null)
                {
                    sb.Append("\\n Email: ");
                    sb.Append(email);
                }
                if (this.backupEmail != null)
                {
                    sb.Append("\\n Backup Email: ");
                    sb.Append(backupEmail);
                }
                if (this.spouseName != null)
                {
                    sb.Append("\\n Spouse Name: ");
                    sb.Append(spouseName);
                }
                if (this.city != null)
                {
                    sb.Append("\\n City: ");
                    sb.Append(city);
                }
                if (this.state != null)
                {
                    sb.Append("\\n State: ");
                    sb.Append(state);
                }
                if (this.country != null)
                {
                    sb.Append("\\n Country: ");
                    sb.Append(country);
                }
                if (this.language != null)
                {
                    sb.Append("\\n Language: ");
                    sb.Append(language);
                }
                if (this.passwordHint != null)
                {
                    sb.Append("\\n Password Hint: ");
                    sb.Append(passwordHint);
                }
                if (this.securityQuestion != null)
                {
                    sb.Append("\\n Security Question: ");
                    sb.Append(securityQuestion);
                }
                if (this.securityAnswer != null)
                {
                    sb.Append("\\n Security Answer: ");
                    sb.Append(securityAnswer);
                }
                return sb.ToString();
                #endregion
            }
        }
    }
}