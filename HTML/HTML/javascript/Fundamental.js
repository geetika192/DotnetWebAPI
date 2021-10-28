//Function is a keyword

/* function walk()  //called
{
    var s = ""
    var fruits = new Array("apple", "orange", "mango");
    for (i = 0; i < fruits.length; i++) //for loop
    {
        s += fruits[i] + " ";
    }
    console.log(s);
} */
// function app() 
// {
//     const person = { fname: "John", lname: "Doe", age: 25 };
//     let text = "";
//     for (let x in person) {  //for in loop
//         text += person[x]+ " ";
//     }
//     console.log(text);
// } 
function app() {
    const cars = ["BMW", "Volvo", "Mini"];

    let text = "";
    for (let x of cars) {
        text += x;
    }
    console.log(text);
}
function walk() //called
{
    var arr=new Array(11,20,30);
    console.log(arr[0]);
    var strArr="";
    for(var i=0;i<arr.length;i++)
    {
        strArr+=arr[i]+" ";
    }
    arr=arr.reverse();
    console.log(arr);
    console.log(strArr);
    
}
walk();
//app();