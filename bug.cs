public class MyClass {
    private int _myField;

    public int MyProperty {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod() {
        // Accessing the private field directly is unconventional and can lead to issues
        // if the property's logic is changed without updating direct field access.
        _myField = 10; 
    }
}