namespace hamsterbyte.DeveloperConsole;

public class DCParameterMismatchException : DCException{
    public DCParameterMismatchException(string methodName, int expectedCount, int actualCount, int leaseCount = default){
        if (leaseCount == default)
            _message = $"{methodName} expects {expectedCount} parameters, {actualCount} was given.";
        else
            _message = $"{methodName} expects at least {leaseCount} and a maximum of {expectedCount} parameters, {actualCount} was given.";
    }
}