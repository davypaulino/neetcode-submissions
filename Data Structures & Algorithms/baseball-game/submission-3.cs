public class Solution {
    public int CalPoints(string[] operations) {
        if (operations.Length == 0)
                return 0;

        List<int> records = new();
        int total = 0;
        for (var i = 0; i < operations.Length; i++) {    
            if (operations[i] == "+") {
                int n = this.Sum(records);
                total += n;
                records.Add(n);
            }
            else if (operations[i] == "D") {
                int n = this.Double(records);
                total += n;
                records.Add(n);
            }
            else if (operations[i] =="C") {
                total -= records[records.Count - 1];
                records.RemoveAt(records.Count - 1);
            }
            else if (int.TryParse(operations[i], out int result)) {
                total += result;
                records.Add(result);
            } 
        }

        return total;
    }

    private int Double(List<int> records) {
        return records.Last() * 2;
    }

    private int Sum(List<int> records) {
        return records[records.Count - 2] + records.Last();
    }
}