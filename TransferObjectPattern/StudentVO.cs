namespace TransferObjectPattern
{
    /// <summary>
    ///     TODOStudentVO
    ///     by gouyf
    ///     2016/6/29 15:27:03
    /// </summary>
    public class StudentVO
    {
        private string name;
        private int rollNo;

        public StudentVO(string name, int rollNo)
        {
            this.name = name;
            this.rollNo = rollNo;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getRollNo()
        {
            return rollNo;
        }

        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }
    }
}