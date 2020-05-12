using System;

namespace ThirtyDaysOfCode.Days
{
    class PersonD12{
        public int age;     
        public PersonD12(int initialAge) 
        {
            
            if( initialAge > 0){
                age = initialAge;
            }else{
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }
        public void amIOld() {
            if(this.age<13){
                Console.WriteLine("You are young.");
            }else if(this.age>=13 && this.age<18){
                Console.WriteLine("You are a teenager.");
            }else{
                Console.WriteLine("You are old.");
            }
        }
        public void yearPasses() {
            this.age += 1;
        }
    }
    public static class Day4
    {
        public static void Execute()
        {
            Console.WriteLine("Enter number of parameters:");
            int T=int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++) {
                Console.WriteLine("Enter person age:");
                int age=int.Parse(Console.In.ReadLine());
                PersonD12 p=new PersonD12(age);
                p.amIOld();
                    for (int j = 0; j < 3; j++) {
                    p.yearPasses();
                    }
                    p.amIOld();
                    Console.WriteLine();
            }
        }
    }
}