var orderButton = document.getElementById("orderButton");
var clearButton = document.getElementById("clearButton");
var receipt = document.getElementById("receipt");

//Event listeners
orderButton.addEventListener("click", () => {
    var inputElemArray = document.getElementsByTagName("input");

    var checkedInputArray = [];
    var checkedInputNameArray = [];
    var priceArray = [];
    //loop through all input elements and check how many are ticked
    for(var i = 0; i < inputElemArray.length; i++) {
        if(inputElemArray[i].checked == true) {
            checkedInputArray.push(inputElemArray[i]);

            var labelElemArray = document.getElementsByTagName("label");
            switch(labelElemArray[i].htmlFor) {
                case "small":
                    priceArray.push(6);
                    checkedInputNameArray.push("Small");
                    break;
                case "medium":
                    priceArray.push(10);
                    checkedInputNameArray.push("Medium");
                    break;
                case "large":
                    priceArray.push(14);
                    checkedInputNameArray.push("Large");
                    break;
                case "extraLarge":
                    priceArray.push(16);
                    checkedInputNameArray.push("Extra Large");
                    break;

                case "pepperoni":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "meat") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Pepperoni");
                    break;
                case "sausage":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "meat") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Sausage");
                    break;
                case "canadianBacon":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "meat") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Canadian Bacon");
                    break;
                case "groundBeef":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "meat") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Ground Beef");
                    break;
                case "anchovy":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "meat") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Anchovy");
                    break;
                case "chicken":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "meat") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Chicken");
                    break;

                case "tomatoes":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "veggies") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Tomatoes");
                    break;
                case "onions":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "veggies") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Onions");
                    break;
                case "greenPeppers":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "veggies") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Green Peppers");
                    break;
                case "mushrooms":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "veggies") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Mushrooms");
                    break;
                case "pineapple":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "veggies") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Pineapple");
                    break;
                case "olives":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "veggies") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Olives");
                    break;
                case "spinach":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "veggies") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Spinach");
                    break;
                case "jalapeno":
                    var checkedArrayLength = checkedInputArray.length;
                    if(checkedInputArray[checkedArrayLength - 2].name == "veggies") {
                        priceArray.push(1);
                    } else {
                        priceArray.push(0);
                    }
                    checkedInputNameArray.push("Jalapeno");
                    break;

                case "regularCheese":
                    priceArray.push(0);
                    checkedInputNameArray.push("Regular Cheese");
                    break;
                case "noCheese":
                    priceArray.push(0);
                    checkedInputNameArray.push("No Cheese");
                    break;
                case "extraCheese":
                    priceArray.push(3);
                    checkedInputNameArray.push("Extra Cheese");
                    break;

                case "marinaraSauce":
                    priceArray.push(0);
                    checkedInputNameArray.push("Marinara Sauce");
                    break;
                case "whiteSauce":
                    priceArray.push(0);
                    checkedInputNameArray.push("White Sauce");
                    break;
                case "barbequeSauce":
                    priceArray.push(0);
                    checkedInputNameArray.push("Barbeque Sauce");
                    break;
                case "noSauce":
                    priceArray.push(0);
                    checkedInputNameArray.push("No Sauce");
                    break;
                
                case "plainCrust":
                    priceArray.push(0);
                    checkedInputNameArray.push("Plain Crust");
                    break;
                case "garlicButterCrust":
                    priceArray.push(0);
                    checkedInputNameArray.push("Garlic Butter Crust");
                    break;
                case "spiceCrust":
                    priceArray.push(0);
                    checkedInputNameArray.push("Spicy Crust");
                    break;
                case "houseSpecialCrust":
                    priceArray.push(0);
                    checkedInputNameArray.push("House Special Crust");
                    break;
                case "cheeseStuffedCrust":
                    priceArray.push(3);
                    checkedInputNameArray.push("Cheese Stuffed Crust");
                    break;
            }
        }
    }
    
    var receiptElemArray = [];
    for(var i = 0; i < checkedInputNameArray.length; i++) {
        receipt.style.display = "block";

        var elem = document.createElement("p");
        elem.innerHTML = checkedInputNameArray[i] + "<span class='floatRight'>$" + priceArray[i] + ".00</span>";
        receipt.appendChild(elem);

        if(i == checkedInputNameArray.length - 1) {
            var br = document.createElement("br");
            
            var sumTitle = document.createElement("h5");
            sumTitle.innerHTML = "Total";
            sumTitle.classList.add("floatRight");

            var sumElem = document.createElement("p");
            sumElem.classList.add("floatRight");
            
            var sum = 0;
            for(var i = 0; i < priceArray.length; i++) {
                sum += priceArray[i];
            }
            sumElem.innerHTML = "$" + sum + ".00";

            receipt.appendChild(sumTitle);
            receipt.appendChild(br);
            receipt.appendChild(sumElem);
        }
    }
});

clearButton.addEventListener("click", () => {
    receipt.innerHTML = `
        <h1 class="heading">Receipt</h1>

        <h2>Item</h2>
        <h2 class="floatRight">Price</h2>
    `;

    receipt.style.display = "none";
});