namespace MVC1387.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool Smoking { get; set; }

        public bool Vaccinated { get; set; }

        public double Bmi
        {
            get
            {
                return Weight / Math.Pow(Height, 2);
            }

            set { }
        }

        public string BmiStatus
        {
            get
            {
                if (Bmi < 18.5)
                {
                    return "Underweight";
                }

                else if (Bmi < 25)
                {
                    return "Good";
                }

                else if (Bmi < 29)
                {
                    return "Overweight";
                }

                else
                {
                    return "Obese";
                }
            }

            set { }
        }
    }

    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public DateTime StartDate {get; set;}
        public string Campus { get; set; }
        public double Salary { get; set; }
        public double Deduction {  get; set; }
        public double NetSalary {  get; set; }
        }
}