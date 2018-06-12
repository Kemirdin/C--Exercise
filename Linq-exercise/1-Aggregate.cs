using System;
namespace Classes {
    private static void Sample_Aggregate_Lambda() {
        var numbers = new int[] { 1, 2, 3, 4, 5 };

        var result = numbers.Aggregate ((a, b) => a * b);

        Debug.WriteLine ("Aggregated numbers by multiplication:");
        Debug.WriteLine (result);
    }

}