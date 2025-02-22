public class MyClass {
    private int _myField;

    public int MyProperty {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod() {
        // Correct way: Access the field through the property
        this.MyProperty = 10; 
    }
}