class program {
    static void Main(string[] args){

        Console.Write("Input Your Password : ");
        int pass = int.Parse(Console.ReadLine());
        Console.Write("Input Your Agency : ");
        string agen = Console.ReadLine();
        
        int a = pass % 10 ; //หน่วย a = 0
        int b = ((pass % 100) - a) / 10 ; //สิบ ba = 00
        int c = ((pass % 1000) - (a + b)) / 100 ; //ร้อย cba = 000
        int d = ((pass % 10000) - (a + b +c)) / 1000 ; //พัน d,cba = 0,000
        int e = ((pass % 100000) - (a + b +c +d)) / 10000 ; //หมื่น ed,cba = 00,000
        int f = ((pass % 1000000) - (a + b + c + d + e)) / 100000 ; //แสน fed,cba = 000,000

        switch (agen){
            case "CIA" :
                if ((a % 3 == 0) && (b != 1 && b != 3 && b != 5) && (d >= 6 && d != 8)){
                    Console.WriteLine(true);
                    Console.WriteLine("You are CIA!!!");
                } else {
                    Console.WriteLine(false);
                }
                break;

            case "FBI" :
                if ((c % 2 == 0 && c != 6) && (e % 2 != 0) && (f >= 4 && f <= 7)){
                    Console.WriteLine(true);
                    Console.WriteLine("You are FBI!!!");
                } else {
                    Console.WriteLine(false);
                }
                break;

            case "NSA" :
                if ((a != 0 && 30 % a == 0) && (c % 3 == 0 && c % 2 != 0) && (b == 7 || d == 7 || e == 7 || f == 7)){
                    Console.WriteLine(true);
                    Console.WriteLine("You are NSA!!!");
                } else {
                    Console.WriteLine(false);
                }
                break;

            default :
                Console.WriteLine(false);
                Console.WriteLine("Who are you ?") ;
                break;
            }
    }
}