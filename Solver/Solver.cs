namespace Solver;

public class StringSolver
{   
    public StringSolver()
    {   
    }
    
    public string FindLongest(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }
        var output = FindLongest(input.Split(' ').Select(x => Int32.Parse(x)).ToArray());
        return string.Join(" ", output);
    }

    public List<int> FindLongest(int[]? inputs)
    {
        if (inputs == null || inputs.Length == 0)
        {
            return new List<int>();
        }

        var maxLength = 0;
        var currentCount = 0;
        var maxLongest = new List<int>();
        var currentLongest = new List<int>();
        for(int i=0;i<inputs.Length - 1;i++)
        {
            if (inputs[i] < inputs[i+1])
            {   
                currentCount++;
                currentLongest.Add(inputs[i]);
            }
            if(inputs[i] >= inputs[i+1])
            {   currentCount++;
                currentLongest.Add(inputs[i]);
                if(maxLength<currentCount)
                {
                    maxLongest = new List<int>(currentLongest);
                    maxLength = currentCount;
                }
                currentCount = 0;
                currentLongest.Clear();
            }
        }
        currentCount++;
        currentLongest.Add(inputs[inputs.Length - 1]);
        if(maxLength<currentCount)
        {
            maxLongest = new List<int>(currentLongest);
            maxLength = currentCount;
        }

        return maxLongest;
    }
}
