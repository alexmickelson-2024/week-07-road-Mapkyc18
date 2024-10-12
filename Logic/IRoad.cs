public interface IRoad
{
  public int RowCount { get; }
  public int ColCount { get; }

  void SetVehicle(int row, int column, IVehicle vehicle);
  IVehicle? GetVehicle(int row, int column);
}

public class Road : IRoad
{
  public int RowCount { get; }
  public int ColCount { get; }
  private IVehicle[,] vehicles;
  public Road(int row, int column)
  {
    RowCount =  row;
    ColCount = column;
    IVehicle[,] vehicles = new IVehicle[row, column];
  }
}