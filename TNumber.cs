namespace Lab1 {
class TNumber {
    // Об’єкт “Число”
    // Поля:
    //   для зберігання натурального числа;
    // Методи:
    //  введення числа;
    //  виведення числа;
    //  знаходження кількості цифр;
    //  знаходження суми цифр.
    private uint num;
    public uint Num {
        get {
            return num;
        } 
        set {
            if (value > 0) {
                num = value;
            } else {
                Console.Error.WriteLine("Fatal Error: number must be natural. ");
                Environment.Exit(1);
            }
        }
    }

    public TNumber() {
        Num = 1;
    }

    public TNumber(uint num) {
        Num = num;
    }

    public static bool IsNatural(string num) {
        var numLen = num.Length;
        if (numLen == 0 || num.ElementAt(0) == '0') {
            return false;
        }
        for (int i = 0; i < numLen; i++) {
            if (!char.IsDigit(num, i)) {
                return false;
            }  
        } 
        return true;

        // return int.TryParse(num, out int number) && number > 0;
        // Allows strings with 0 in the beggining, e.g. "001"
    }

    public void Input() {
        string? numStr;
        while (true) {
            Console.Write("num = ");
            numStr = Console.ReadLine();
            if (numStr is null) {
                Console.WriteLine("Error: couldn't set <num> field of object. Try again.");
                continue;
            }
            if (IsNatural(numStr)) {
                Num = uint.Parse(numStr);
                break;
            } else {
                Console.WriteLine("Error: number must be natural. Try again.");
            }
        }
    }

    public void Print() {
        Console.WriteLine("Field <num> = {0}", Num);
    }
    public int GetDigitCount() {
        // var numCopy = Num;
        // int digitCount = 0;
        // while (numCopy > 0) {
        //     numCopy /= 10;
        //     digitCount += 1;
        // }
        // return digitCount;
        return Num.ToString().Length;
    }
    public int GetDigitSum() {
        // int numCopy = (int)Num;
        // int digitSum = 0;
        // while (numCopy > 0) {
        //     int digit = numCopy % 10;
        //     digitSum += digit;
        //     numCopy /= 10;
        // }
        // return digitSum;
        return Num.ToString().Sum(c => (int)char.GetNumericValue(c));
    }
}
}