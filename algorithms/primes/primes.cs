  /*
  *
  * Bojan Skrchevski 2018-03-22
  *
  * A very simple prime numbers algorithm.
  *
  */

  static void Main(String[] args) {
    
        int p = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < p; a0++) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Out.WriteLine(isPrime(n) ? "Prime" : "Not prime");
        }
    }
    
    static bool isPrime(int n) {
      
        if (n < 2) {
            return false;
        } else if (n == 2) {
            return true;
        } 
        // skip all divisible by 2 and 3 (no need, since they are not primes)
        else if (n % 2 == 0 || n % 3 == 0) {
            return false;
        }
        
        // go only to sqrt(n)
        var sqrtN = Math.Sqrt(n);
        for (int i=3; i<(int)sqrtN+1; i++) {
            if(n % i == 0) return false;
        }
        
        return true;
    }
