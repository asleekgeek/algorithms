
/**
 *
 *
 *  Implemenattion of union–find data type
 *  (also known as the disjoint-sets data type).
 *  It supports the union and find operations,
 *  along with a connected operation for determining whether
 *  two sites are in the same component and a count operation that
 *  returns the total number of components.
 *
 *  
 */


using System;

public class QuickFindUF {
    private int[] id;    // id[i] = component identifier of i
    private int numberOfComponents;   // number of components
    
    public QuickFindUF(int n) {
        numberOfComponents = n;
        id = new int[n];
        for (int i = 0; i < n; i++)
            id[i] = i;
    }

    public void Union(int p, int q) {
        Validate(p);
        Validate(q);
        int pID = id[p];   // needed for correctness
        int qID = id[q];   // to reduce the number of array accesses

        // p and q are already in the same component
        if (pID == qID) return;

        for (int i = 0; i < id.Length; i++) {
            if (id[i] == pID) id[i] = qID; 
        }
        numberOfComponents--;
    }

    public int Find(int p) {
        Validate(p);
        return id[p];
    }

    public bool Connected(int p, int q) {
        Validate(p);
        Validate(q);
        return id[p] == id[q];
    }
  
    public int Count() {
        return numberOfComponents;
    }

    // validate that p is a valid index
    private void Validate(int p) {
        int n = id.Length;

        if (p < 0 || p >= n) {
            throw new ArgumentException("index " + p + " is not between 0 and " + (n-1));
        }
    }

    public static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        QuickFindUF uf = new QuickFindUF(n);
        string line;
        
        while ((line = Console.ReadLine()) != null && line != "") {

            string[] a_temp = line.Split(' ');
            int[] array = Array.ConvertAll(a_temp, Int32.Parse);
            int p = array[0];
            int q = array[1];

            if (uf.Connected(p, q)) continue;
            uf.Union(p, q);
            
            Console.WriteLine(p + " " + q);
        }
        Console.WriteLine(uf.Count() + " components");
        Console.ReadLine();
    }
}
