public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        int userOption;

        do
        {
            userOption = DisplayMenu();

            switch (userOption)
            {
                case 1 :

                    CreateGoal();
                    break;
                case 2 :

                    ListGoalNames();
                    break;
                case 3 :
                    Console.Clear();
                    SaveGoals();
                    break;
                case 4 :
                    Console.Clear();
                    LoadGoals();
                    break;
                case 5 :
                    Console.Clear();
                    RecordEvent();
                    break;
            }

            DisplayPlayerInfo();
        } while (userOption != 6);
    }

    private int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Goals");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");

        return int.Parse(Console.ReadLine());
    }

    private void DisplayPlayerInfo(){
        Console.WriteLine($"\nYour have {_score} points.\n");
    }

    private void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetStringDetails()}");
            index++;
        }
    }

    private void ListGoalDetails ()
    {
        
    }

    private void CreateGoal ()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create?: ");

        int goalType = int.Parse(Console.ReadLine());
        
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                this._goals.Add(new SimpleGoal(goalName, description, points));
                break;
            case 2:
                this._goals.Add(new EternalGoal(goalName, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                this._goals.Add(new ChecklistGoal(target, bonus, goalName, description, points));
                break;
        }
    }

    private void RecordEvent ()
    {
        Console.WriteLine("The goals are: ");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetShortName()}");
            index++;
        }

        Console.Write("Which goal did you accomplished? ");
        int accomplishedTask = int.Parse(Console.ReadLine());
        accomplishedTask--;
        
        int pointsEarned = _goals[accomplishedTask].RecordEvent(); 
        _score+= pointsEarned;
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
    }

    private void SaveGoals ()
    {
        Console.Write("Enter the Goals filename: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"{_score}");
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine($"{goal.GetStringRepresentation()}");
                }
            }

            Console.WriteLine($"Goals saved to {filename} successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the Goals file: {ex.Message}\n");
        }
    }

    private void LoadGoals ()
    {
        Console.Write("Enter the filename to load the Goals: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _goals.Clear();
                Console.WriteLine($"Goals loaded from {filename} successfully!\n");
                string line = reader.ReadLine();
                _score = int.Parse(line);
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    if (parts[0] == "SimpleGoal")
                    {
                        SimpleGoal goalItem = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (parts[4] == "True")
                        {
                            goalItem.SetIsComplete(true);
                        }else{
                            goalItem.SetIsComplete(false);
                        }
                        
                        this._goals.Add(goalItem);
                    }else if (parts[0] == "EternalGoal")
                    {
                        EternalGoal goalItem = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));                        
                        this._goals.Add(goalItem);
                    }else
                    {
                        ChecklistGoal goalItem = new ChecklistGoal(int.Parse(parts[5]), int.Parse(parts[6]), parts[1], parts[2], int.Parse(parts[3]));
                        goalItem.SetAmountCompleted(int.Parse(parts[4]));
                        this._goals.Add(goalItem); 
                    }
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}\n");
        }
    }

    
}