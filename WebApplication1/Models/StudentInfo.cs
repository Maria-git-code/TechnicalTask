namespace WebApplication1.Models
{
    public class StudentInfo
    {
        public Student student { get; set; }
        public Group group1 { get; set; }

        public Group group2 { get; set; }

        public Marks marks1 { get; set; }

        public Marks marks2 { get; set; }

        public void checkInfo(ReportInfo report){
            String tempYear = report.year.ToString();
            String tempGroup = report.group.ToString();
            String month1 = report.month1.ToString();
            String month2 = report.month2.ToString();
            if (tempYear == "2020-2021")
            {
                if((this.group1.Sp == tempGroup) || (this.group1.Oct == tempGroup) || (this.group1.Nv == tempGroup) || (this.group1.Dc == tempGroup) || (this.group1.Jn == tempGroup) || (this.group1.Fbr == tempGroup) || (this.group1.Mrch == tempGroup) || (this.group1.Apr == tempGroup) || (this.group1.May == tempGroup))
                {

                }

            }
            if (tempYear == "2021-2022")
            {
                if ((this.group2.Sp == tempGroup) || (this.group2.Oct == tempGroup) || (this.group2.Nv == tempGroup) || (this.group2.Dc == tempGroup) || (this.group2.Jn == tempGroup) || (this.group2.Fbr == tempGroup) || (this.group2.Mrch == tempGroup) || (this.group2.Apr == tempGroup) || (this.group2.May == tempGroup))
                {

                }
            }
        }

        public void getMarks(String m1, String m2)
        {
            float sum = 0;
            List<String> list = new List<string>() { "9", "10","11", "12", "1","2", "3","4", "5" };

            int i = 0;

            
            
            foreach(String s in list)
            {
                if(s == m1)
                {

                }
            }


        }





        public String getMarkMonth(String monthNumb)
        {
            String temp = "";
            switch (monthNumb)
            {
                case "9":
                    temp = this.marks1.Sp;
                    break;
                case "10":
                    temp = this.marks1.Oct;
                    break;
                case "11":
                    temp = this.marks1.Nv;
                    break;
                case "12":
                    temp = this.marks1.Dc;
                    break;
                case "1":
                    temp = this.marks1.Jn;
                    break;
                case "2":
                    temp = this.marks1.Fbr;
                    break;
                case "3":
                    temp = this.marks1.Mrch;
                    break;
                case "4":
                    temp = this.marks1.Apr;
                    break;
                case "5":
                    temp = this.marks1.May;
                    break;
                
            }
            return temp;
        }

    }
}
