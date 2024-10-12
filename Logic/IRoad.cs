public interface IRoad
{
  public int RowCount { get; }
  public int ColCount { get; }

  void SetVehicle(int row, int column, IVehicle vehicle);
  IVehicle? GetVehicle(int row, int column);
}

public class Road : IRoad
{
    private int  rowCount;
    private int columnCount;
    public int RowCount
    {
      get { return rowCount; }
      set { rowCount = value; }
    }
    public int ColCount
    {
      get { return columnCount; }
      set { columnCount = value; }
    }
    

}