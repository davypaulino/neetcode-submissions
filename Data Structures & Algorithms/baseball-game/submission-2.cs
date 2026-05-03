public class Solution {
    public int CalPoints(string[] operations) {
        if (operations.Length == 0)
                return 0;

        List<int> records = new();
        for (var i = 0; i < operations.Length; i++) {
            if(int.TryParse(operations[i], out int result)) {
                records.Add(result);
            }      
            else if (operations[i] == "+") {
                records.Add(this.Sum(records));
            }
            else if (operations[i] == "D") {
                records.Add(this.Double(records));
            }
            else if (operations[i] =="C") {
                records.RemoveAt(records.Count - 1);
            }

        }

        return records.Sum();
    }

    private int Double(List<int> records) {
        return records.Last() * 2;
    }

    private int Sum(List<int> records) {
        return records[records.Count - 2] + records.Last();
    }
}