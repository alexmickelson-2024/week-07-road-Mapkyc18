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
  public Road(int rowCount, int colCount)
  {
    RowCount =  rowCount;
    ColCount = colCount;
    IVehicle[,] vehicles = new IVehicle[rowCount, colCount];
  }

  public IVehicle? GetVehicle(int row, int column)
  {
    return vehicles[row,cloumn];
  }
  void SetVehicle(int row, int column, IVehicle vehicle)
  {
    if(row >= 0 && row < RowCount && column >= 0 && column < ColCount)
      vehicles[row, column] = vehicle;
  }

}