public class Activity{
    protected string _activityName;
    protected string _description;

    protected List<string> animationStrings = new List<string> {"/","-","|","\\"};
    
    public Activity (string activityName, string description){
        _activityName = activityName;
        _description = description;
    }

    public virtual void ExecuteActivity(int duration){
        //Use virtual to allow method overriding in child class
        //placeholder method to be overrided into child classes
    }

    public virtual void ExecuteActivity(int duration, int frequency){
        //Use virtual to allow method overriding in child class
        //placeholder method to be overrided into child classes
    }

    /// <summary>
    /// Print welcome message and collect values needed to be provided as arguments for executing activities
    /// </summary>
    /// <returns>List of int values(duration and/or frequency)</returns>
    public virtual List<int> WelcomeMessage(){
        List<int> values = new List<int>();
        int duration = 0;

        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine($"\n{_description}");
        
        Console.Write("\nHow long in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        
        values.Add(duration);
        return values;
    }

    public void getReady(){
        Console.WriteLine("Get ready...");
        spinnerAnimation(5);
    }

    public void spinnerAnimation(int duration){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        while(DateTime.Now < endTime){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");            

            i++;

            if(i >= animationStrings.Count){
                i = 0;
            }
        }
    }

    public void counterAnimation(int duration){
        for(int i=duration;i>0;i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    public void completeMessage(int duration){
        Console.WriteLine("\n");
        Console.WriteLine("Well done!!");
        spinnerAnimation(5);
        
        Console.WriteLine($"You have completed another {duration} second/s of the {_activityName}");
        spinnerAnimation(5);

        Console.Clear();
    }
}