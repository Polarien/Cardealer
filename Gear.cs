public class Gear{

    #region Fields
    private int _currentGear = 0;
    private bool _isAutomatic = false;
    private int _maxGear = 5;
    #endregion

    #region Constructors
    public Gear(int startGear, bool automatic, int maxGear){
        _currentGear = startGear;
        _isAutomatic = automatic;
        _maxGear = maxGear;
    }

    public Gear(bool automatic){
        _isAutomatic = automatic;
    }
    #endregion

    #region methods
    public void ChangeGear(int gear){
        if(gear < _maxGear){
            _currentGear = gear;
        }
    }
    #endregion
}
