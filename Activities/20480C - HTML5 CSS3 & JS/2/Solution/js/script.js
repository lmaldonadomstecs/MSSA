// Elements of the calculator
var screen = document.getElementById("screen");
var divBtn = document.getElementsByClassName("operation")[0];
var multBtn = document.getElementsByClassName("operation")[1];
var substBtn = document.getElementsByClassName("operation")[2];
var addBtn = document.getElementsByClassName("operation")[4];
var equalsBtn = document.getElementsByClassName("operation")[3];

// Variables for the program
var first;
var second;
var operation;
var finishedFlag;

function refreshCalculator() {
    screen.innerHTML = "0";
    equalsBtn.setAttribute("class", "button operation disabled");
    divBtn.setAttribute("class", "button operation");
    multBtn.setAttribute("class", "button operation");
    substBtn.setAttribute("class", "button operation");
    addBtn.setAttribute("class", "button operation");
    first = null;
    second = null;
    this.finishedFlag = false;
}

function addNumber(number) {
    if (!this.finishedFlag) {
        if(screen.innerHTML == 0) {
            screen.innerHTML = number;
        } else {
            screen.innerHTML += number;
        }
    } else {
        refreshCalculator();
    }
}

function captureNumber(operation) {
    if (!this.finishedFlag) {
        if (first == null) {
            this.first = parseInt(screen.innerHTML);
            this.operation = operation;
            screen.innerHTML = "0";
            divBtn.setAttribute("class", "button operation disabled");
            multBtn.setAttribute("class", "button operation disabled");
            substBtn.setAttribute("class", "button operation disabled");
            addBtn.setAttribute("class", "button operation disabled");
            equalsBtn.setAttribute("class", "button operation");
        }
    } else {
        refreshCalculator();
    }
}

function giveResult() {
    if (!this.finishedFlag) {
        this.second = parseInt(screen.innerHTML);
        equalsBtn.setAttribute("class", "button operation disabled");
        switch (this.operation) {
            case 'addition':
                screen.innerHTML = first + second;
                break;
            case 'substraction':
                screen.innerHTML = first - second;
                break;
            case 'multiplication':
                screen.innerHTML = first * second;
                break;
            case 'division':
                screen.innerHTML = first / second;
                break;
        }
    } else {
        refreshCalculator();
    }
    this.finishedFlag = true;
}

refreshCalculator();