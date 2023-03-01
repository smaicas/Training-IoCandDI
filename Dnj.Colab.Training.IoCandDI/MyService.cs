namespace Dnj.Colab.Training.IoCandDI;
public class MyService
{
    private readonly IMyServiceTwo _serviceTwo;
    private readonly IMyRepository _repository;

    public MyService(IMyServiceTwo serviceTwo, IMyRepository repository)
    {
        _serviceTwo = serviceTwo;
        _repository = repository;
    }

    public void Run()
    {
        _serviceTwo.Do();
        _repository.GetData();
    }
}
