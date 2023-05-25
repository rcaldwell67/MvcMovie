// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Assign Form by Id to a Variabe
$(document).ready(function () {
    //var myForm = document.getElementById("oddsForm");
    ////Extract Each Element Value
    //for (var i = 0; i < myForm.elements.length; i++) {
    //    console.log(myForm.elements[i].value);
    //}
});


//var decOddsFA;
//var decOddsFA1;
//var decOddsFA2;
//var decOddsFA3;
//var decOddsFA4;
//var decOddsUD;
//var decOdds;
//Form Load
$('#divFA').hide();
$('#divUD').hide();
$(function () {
    $('#Side').change(function () {
        var s = $(this).val();
        var t = $('#Type').val();
        console.log(t);
        if (s == "2" && t == "2") {
            $('#divUD').show();
        } else { $('#divUD').hide(); }
        if (s == "1" && t == "1") {
            $('#divFA').show();
        } else { $('#divFA').hide(); }
    });
    $('#Type').change(function () {
        var s = $(this).val();
        var t = $('#Side').val();
        console.log(t);
        if (s == "2" && t == "2") {
            $('#divUD').show();
        } else { $('#divUD').hide(); }
        if (s == "1" && t == "1") {
            $('#divFA').show();
        } else { $('#divFA').hide(); }
    });
});

//$("#LegFA")
//    .replaceWith('<select id="LegFA" name="LegFA" class="form-control">' + // class="ProductDetailsQuantityTextBox">' +
//        '<option value="0">Select</option>' +
//        '<option value="1">1</option>' +
//        '<option value="2">2</option>' +
//        '<option value="3">3</option>' +
//        '<option value="4">4</option>' +
//        '</select>');
$("#LegUD")
    .replaceWith('<select id="LegUD" name="LegUD" class="form-control">' + // class="ProductDetailsQuantityTextBox">' +
        '<option value="0">Select</option>' +
        '<option value="1">1</option>' +
        '<option value="2">2</option>' +
        '<option value="3">3</option>' +
        '<option value="4">4</option>' +
        '</select>');
$("#Side")
    .replaceWith('<select id="Side" name="Side" class="form-control">' + // class="ProductDetailsQuantityTextBox">' +
    '<option value="0">Select</option>' +
    '<option value="1">FA</option>' +
    '<option value="2">UD</option>' +
    '</select>');
$("#Type")
    .replaceWith('<select id="Type" name="Type" class="form-control">' + // class="ProductDetailsQuantityTextBox">' +
        '<option value="0">Select</option>' +
        '<option value="1">4Team</option>' +
        '<option value="2">SingleBet</option>' +
        '</select>');
//Calculate

//DecOdds
//Get Odds

$(function () {
    $('#Odds').change(function () {
        odds = $(this).val();//.toString()
        console.log("odds: " + odds);
        //alert("oddsUD: " + oddsUD);
        if (odds.includes("-")) {
            decOddsFA = Number((parseInt(odds) - 100) / odds).toFixed(2);
            decOdds = decOddsFA;
            console.log("decOddsFA: " + Number(decOddsFA).toFixed(2));
            $('#DecOdds').val(decOddsFA);
        } else {
            decOddsUD = Number((odds / 100) + 1).toFixed(2);
            decOdds = decOddsUD
            console.log("decOddsUD: " + Number(decOddsUD).toFixed(2));
            $('#DecOdds').val(decOddsUD);
        }

        //Calculation for Single Bets
        //Use FA 4Team Win For Payout - ex. = 100
        //Payout = Win + Bet
        //Set Payout
        //$('#Payout').val(100);
        //var b = 5; // $('#Bet').val(100);
        //var w = Math.abs((b * decOddsUD)); // - wagerFave);
        //console.log(w);
        ////$('#profitFave').val(Number(profitFave).toFixed(2));
        ////Bet = Win / DecOdds
        //$('#Win').val(Number(w).toFixed(2));

        //Win = Bet * DecOdds
        //$('#Win').val(100);

        //var oddsUDLen = $('#oddsUD').val().length;
        //if (oddsUD.includes("-") || oddsUD.includes("+")) {
        //    oddsUDLen = oddsUDLen - 1;
        //}

        //if (!isNaN(oddsUD) && oddsUDLen >= 3) {
        //    if ($('#wagerUD').val() != 0) {
        //        getOddsInputs();
        //    }
        //} else {
        //    //add Validation Error Code for Odds Input Fields
        //    if (oddsUD != 0) {
        //        oddsInputValidation();
        //    }
        //}
        //calcProfit();
    });

    $('#OddsFA1').change(function () {
        odds = $(this).val();//.toString()
        console.log("Odds1FA: " + odds);
        //alert("oddsUD: " + oddsUD);
        if (odds.includes("-")) {
            decOddsFA1 = Number((parseInt(odds) - 100) / odds).toFixed(2);
            decOdds = decOddsFA1;
            console.log("decOddsFA1: " + Number(decOddsFA1).toFixed(2));
            $('#DecOddsFA1').val(decOddsFA1);
        } else {
            decOddsUD1 = Number((odds / 100) + 1).toFixed(2);
            decOdds = decOddsUD1;
            console.log("decOddsUD1: " + Number(decOddsUD1).toFixed(2));
            $('#DecOddsUD1').val(decOddsUD1);
        }

        //calcProfit();
    });
    $('#OddsFA2').change(function () {
        odds = $(this).val();//.toString()
        console.log("OddsFA2: " + odds);
        //alert("oddsUD: " + oddsUD);
        if (odds.includes("-")) {
            decOddsFA2 = Number((parseInt(odds) - 100) / odds).toFixed(2);
            decOdds = decOddsFA2;
            console.log("decOddsFA2: " + Number(decOddsFA2).toFixed(2));
            $('#DecOddsFA2').val(decOddsFA2);
        } else {
            decOddsUD2 = Number((odds / 100) + 1).toFixed(2);
            decOdds = decOddsUD2;
            console.log("decOddsUD2: " + Number(decOddsUD2).toFixed(2));
            $('#DecOddsUD2').val(decOddsUD2);
        }

        //calcProfit();
    });
    $('#OddsFA3').change(function () {
        odds = $(this).val();//.toString()
        console.log("OddsFA3: " + odds);
        //alert("oddsUD: " + oddsUD);
        if (odds.includes("-")) {
            decOddsFA3 = Number((parseInt(odds) - 100) / odds).toFixed(2);
            decOdds = decOddsFA3;
            console.log("decOddsFA3: " + Number(decOddsFA3).toFixed(2));
            $('#DecOddsFA3').val(decOddsFA3);
        } else {
            decOddsUD3 = Number((odds / 100) + 1).toFixed(2);
            decOdds = decOddsUD3;
            console.log("decOddsUD3: " + Number(decOddsUD3).toFixed(2));
            $('#DecOddsUD3').val(decOddsUD3);
        }

        //calcProfit();
    });
    $('#OddsFA4').change(function () {
        odds = $(this).val();//.toString()
        console.log("OddsFA4: " + odds);
        //alert("oddsUD: " + oddsUD);
        if (odds.includes("-")) {
            decOddsFA4 = Number((parseInt(odds) - 100) / odds).toFixed(2);
            decOdds = decOddsFA4;
            console.log("decOddsFA4: " + Number(decOddsFA4).toFixed(2));
            $('#DecOddsFA4').val(decOddsFA4);
        } else {
            decOddsUD4 = Number((odds / 100) + 1).toFixed(2);
            decOdds = decOddsUD4;
            console.log("decOddsUD4: " + Number(decOddsUD4).toFixed(2));
            $('#DecOddsUD4').val(decOddsUD4);
        }

        //calcProfit();
    });
});

//Bet
//Use a While/For Loop to Calculate Win and Bet From Payout
function calcProfit() {
    console.log("calcProfit");

    $('#Bet').change(function () {
        var b = $(this).val();
        var o = decOdds;
        console.log("Bet " + b);
        console.log("Odds " + o);
        w = Math.abs((b * o));
        console.log("Win " + w);
        //Win = Bet * DecOdds
        //$('#Win').val(Number(w).toFixed(2));
        //Payout = Win - Bet
        //$('#Payout').val(Number(Math.abs(b - w)).toFixed(2));

        //if (s == "2" && t == "2") {
        //    $('#divUD').show();
        //} else { $('#divUD').hide(); }
    });
}

////Win
//$(function () {
//    $('#Win').change(function () {
//        var s = $(this).val();
//        var t = $('#Type').val();
//        console.log(t);
//        if (s == "2" && t == "2") {
//            $('#divUD').show();
//        } else { $('#divUD').hide(); }
//    });
//    $('#Type').change(function () {
//        var s = $(this).val();
//        var t = $('#Side').val();
//        console.log(t);
//        if (s == "2" && t == "2") {
//            $('#divUD').show();
//        } else { $('#divUD').hide(); }
//    });
//});
//Payout
$(function () {
    $('#Payout').change(function () {
        //Payout = Win - Bet
        //Positive american odds - (The decimal value minus one) multiplied by 100 e.g.a decimal value of 3 = (3 - 1) * 100 = 200.
        //Negative american odds - Negative 100 divided by(the decimal odds minus one) e.g.a decimal value of 1.2 = -100 / (1.2 - 1) = -500.
        console.log("payout");
        if (decOddsFA1 > 0 && decOddsFA2 > 0 && decOddsFA3 > 0 && decOddsFA4 > 0) {
            decOdds = decOddsFA1 * decOddsFA2 * decOddsFA3 * decOddsFA4;
            $('#DecOdds').val(Number(decOdds).toFixed(2));
        }
        
        var p = $(this).val();
        console.log("Payout " + Number(p).toFixed(2));
        var w = 0; var b = 0.50;
        //while ((b + w) < p) {
        while (p > w - b) {
            w = b * Number(decOdds).toFixed(2) 
            b += 0.01
            console.log("Bet " + b);
            console.log("Win " + w);
        }
        console.log("Bet " + b);
        console.log("Win " + w);
        $('#Bet').val(Number(b).toFixed(2));
        $('#Win').val(Number(w).toFixed(2));
//        var t = $('#Type').val();
        
//        if (s == "2" && t == "2") {
//            $('#divUD').show();
//        } else { $('#divUD').hide(); }
//    });
//    $('#Type').change(function () {
//        var s = $(this).val();
//        var t = $('#Side').val();
//        console.log(t);
//        if (s == "2" && t == "2") {
//            $('#divUD').show();
//        } else { $('#divUD').hide(); }
    });
});
////Profit

function calculate() {
    console.log("DecOdds1FA: " + $('#DecOdds1FA').val())
    //Variables
    var TotalPayoutFA;
    var TotalPayoutUD;
    var TotalBetFA;
    var TotalBetUD;
    var TotalWinFA;
    var TotalWinUD;
    var ProfitFA;
    var ProfitUD;

    //Validate Each Leg - Odds and Payout Entries
    var myForm = document.getElementById("oddsForm");

    //Extract Each Element Value
    for (var i = 0; i < myForm.elements.length; i++) {
        //console.log(myForm.elements[i].id + " : " + myForm.elements[i].value);
        if (myForm.elements[i].id.includes("Odds")  && myForm.elements[i].value.includes("-")) {
            var decOddsFA = Number((parseInt(myForm.elements[i].value) - 100) / myForm.elements[i].value).toFixed(2);
            console.log("Dec" + myForm.elements[i].id + ":" + Number(decOddsFA).toFixed(2));
            $('#Dec' + myForm.elements[i].id).val(decOddsFA);
        }
        if (myForm.elements[i].id.includes("Odds") && myForm.elements[i].value.includes("+")) {
            var decOddsUD = Number((myForm.elements[i].value / 100) + 1).toFixed(2);
            console.log("Dec" + myForm.elements[i].id + ":" + Number(decOddsUD).toFixed(2));
            $('#Dec' + myForm.elements[i].id).val(decOddsUD);
        }
    }
    
    //4 Team Total
    //FA Payout
    if ($('#DecOdds1FA').val() != null && $('#DecOdds1FA').val() != "" && $('#DecOdds2FA').val() != null && $('#DecOdds2FA').val() != "" &&
        $('#DecOdds3FA').val() != null && $('#DecOdds3FA').val() != "" && $('#DecOdds4FA').val() != null && $('#DecOdds4FA').val() != "") {
        var decOddsFA = $('#DecOdds1FA').val() * $('#DecOdds2FA').val() * $('#DecOdds3FA').val() * $('#DecOdds4FA').val();
        console.log("decOddsFA: " + Number(decOddsFA).toFixed(2));
        $('#TotalDecOddsFA').val(Number(decOddsFA).toFixed(2));

        //Calculate Totals For FA 4 Team Parlay
        //TotalPayoutFA Payout1FA
        var p = $('#TotalPayoutFA').val();
        console.log("TotalPayoutFA: " + Number(p).toFixed(2));
        var w = 0; var b = 0.50;
        //while ((b + w) < p) {
        while (p > w - b) {
            w = b * Number(decOddsFA).toFixed(2)
            b += 0.01
            console.log("TotalBetFA: " + b);
            console.log("TotalWinFA: " + w);
        }
        console.log("TotalBetFA: " + b);
        console.log("TotalWinFA: " + w);
        $('#TotalBetFA').val(Number(b).toFixed(2));
        $('#TotalWinFA').val(Number(w).toFixed(2));
        TotalPayoutFA = p;
        TotalBetFA = b;
        TotalWinFA = w;
    }

    //UD Payout
    if ($('#DecOdds1UD').val() != null && $('#DecOdds1UD').val() != "" && $('#DecOdds2UD').val() != null && $('#DecOdds2UD').val() != "" &&
        $('#DecOdds3UD').val() != null && $('#DecOdds3UD').val() != "" && $('#DecOdds4UD').val() != null && $('#DecOdds4UD').val() != "") {

        var decOddsUD = $('#DecOdds1UD').val() * $('#DecOdds2UD').val() * $('#DecOdds3UD').val() * $('#DecOdds4UD').val();
        console.log("decOddsUD: " + Number(decOddsUD).toFixed(2));
        $('#TotalDecOddsUD').val(Number(decOddsUD).toFixed(2));

        //Calculate Totals For UD 4 Team Parlay
        //TotalPayoutUD Payout1UD
        var p = $('#TotalPayoutUD').val();
        console.log("TotalPayoutUD: " + Number(p).toFixed(2));
        var w = 0; var b = 0.50;
        //while ((b + w) < p) {
        while (p > w - b) {
            w = b * Number(decOddsFA).toFixed(2)
            b += 0.01
            console.log("TotalBetUD: " + b);
            console.log("TotalWinUD: " + w);
        }
        console.log("TotalBetUD: " + b);
        console.log("TotalWinUD: " + w);
        $('#TotalBetUD').val(Number(b).toFixed(2));
        $('#TotalWinUD').val(Number(w).toFixed(2));
        TotalPayoutUD = p;
        TotalBetUD = b;
        TotalWinUD = w;
    }

    //Profit
    //Variables - ProfitFA, ProfitUD, ProfitUD1, ProfitUD2, ProfitUD3, ProfitUD4
    // 4 Team FA Profit = TotalPayoutFA - TotalBetUD - Bet1UD - Bet2UD - Bet3UD - Bet4UD

    ProfitFA = TotalPayoutFA - TotalBetUD; // - Bet1UD - Bet2UD - Bet3UD - Bet4UD;
    ProfitUD = TotalPayoutUD - TotalBetFA; // - Bet1UD - Bet2UD - Bet3UD - Bet4UD;
    console.log("ProfitFA: " + ProfitFA);
    console.log("ProfitUD: " + ProfitUD);
    $('#ProfitFA').val(Number(ProfitFA).toFixed(2));
    $('#ProfitUD').val(Number(ProfitUD).toFixed(2));

    //Calculate Payout By leg For UD Usiing Bet,Win,Payout For 4 Team FA
    var TotalCost;
    TotalCost = TotalBetFA + TotalBetUD;
    console.log("TotalCost: " + TotalCost);
    $('#TotalCost').val(Number(TotalCost).toFixed(2));

    //Leg1
    if ($('#DecOdds1UD').val() != null && $('#DecOdds1UD').val() != "") {
        //ProfitUD1 = Win1UD - TotalCost
        //Payout1UD = Win1UD + Bet1UD
        //Bet1UD = Win1UD / DecOdds1UD
        var w = $('#TotalBetFA').val() * 1.5;
        var pt = w - $('#TotalCost').val();
        var b = w / $('#DecOdds1UD').val();
        var p = w + b;
        $('#Win1UD').val(Number(w).toFixed(2));
        $('#ProfitUD1').val(Number(pt).toFixed(2));
        $('#Bet1UD').val(Number(b).toFixed(2));
        $('#Payout1UD').val(Number(p).toFixed(2));

        while (pt < $('#TotalCost').val()) {
            b += 0.01
            w = b * Number($('#DecOdds1UD').val()).toFixed(2)
            p = w + b;
            pt = w - $('#TotalCost').val(); 
            console.log("Bet1UD: " + b);
            console.log("Win1UD: " + w);
            console.log("Payout1UD: " + p);
            console.log("ProfitUD1: " + pt);
        }
        $('#Win1UD').val(Number(w).toFixed(2));
        $('#ProfitUD1').val(Number(pt).toFixed(2));
        $('#Bet1UD').val(Number(b).toFixed(2));
        $('#Payout1UD').val(Number(p).toFixed(2));
        $('#ProfitFA').val(Number(ProfitFA - pt).toFixed(2));
    }

    TotalCost = TotalBetFA + TotalBetUD + parseFloat($('#Bet1UD').val());
    console.log("TotalCost: " + TotalCost);
    $('#TotalCost').val(Number(TotalCost).toFixed(2));

    //Leg2
    if ($('#DecOdds2UD').val() != null && $('#DecOdds2UD').val() != "") {
        //ProfitUD2 = Win2UD - TotalCost - Bet1UD
        //Payout2UD = Win2UD + Bet2UD
        //Bet2UD = Win2UD / DecOdds2UD
        var w = parseFloat($('#Win1UD').val()) + 6;
        var c = Number($('#TotalCost').val()).toFixed(2);
        //var c2 = + Number($('#Bet1UD').val()).toFixed(2);
        c = parseFloat(c);
        var pt = w - c;
        var b = w / $('#DecOdds2UD').val();
        var p = w + b;
        $('#Win2UD').val(Number(w).toFixed(2));
        $('#ProfitUD2').val(Number(pt).toFixed(2));
        $('#Bet2UD').val(Number(b).toFixed(2));
        $('#Payout2UD').val(Number(p).toFixed(2));
        
        //while (pt < c) {
        //    b += 0.01
        //    w = b * Number($('#DecOdds2UD').val()).toFixed(2)
        //    p = w + b;
        //    pt = w - $('#TotalCost').val();
        //    console.log("Bet2UD: " + b);
        //    console.log("Win2UD: " + w);
        //    console.log("Payout2UD: " + p);
        //    console.log("ProfitUD2: " + pt);
        //}
        ProfitFA = $('#ProfitFA').val();
        $('#Win2UD').val(Number(w).toFixed(2));
        $('#ProfitUD2').val(Number(pt).toFixed(2));
        $('#Bet2UD').val(Number(b).toFixed(2));
        $('#Payout2UD').val(Number(p).toFixed(2));
        $('#ProfitFA').val(Number(ProfitFA - pt).toFixed(2));
    }

    TotalCost = TotalBetFA + TotalBetUD + parseFloat($('#Bet1UD').val()) + parseFloat($('#Bet2UD').val());
    console.log("TotalCost: " + TotalCost);
    $('#TotalCost').val(Number(TotalCost).toFixed(2));

    //Leg3
    if ($('#DecOdds3UD').val() != null && $('#DecOdds3UD').val() != "") {
        //ProfitUD3 = Win3UD - TotalCost - Bet1UD - Bet2UD
        //Payout3UD = Win3UD + Bet3UD
        //Bet3UD = Win3UD / DecOdds3UD
        var w = parseFloat($('#Win2UD').val()) + 9;
        var c = Number($('#TotalCost').val()).toFixed(2);
        //var c2 = Number($('#Bet1UD').val()).toFixed(2);
        //var c3 = Number($('#Bet2UD').val()).toFixed(2);
        c = parseFloat(c);
        var pt = w - c;
        var b = w / $('#DecOdds3UD').val();
        var p = w + b;
        $('#Win3UD').val(Number(w).toFixed(2));
        $('#ProfitUD3').val(Number(pt).toFixed(2));
        $('#Bet3UD').val(Number(b).toFixed(2));
        $('#Payout3UD').val(Number(p).toFixed(2));

        //while (pt < c) {
        //    b += 0.01
        //    w = b * Number($('#DecOdds3UD').val()).toFixed(2)
        //    p = w + b;
        //    pt = w - $('#TotalCost').val();
        //    console.log("Bet3UD: " + b);
        //    console.log("Win3UD: " + w);
        //    console.log("Payout3UD: " + p);
        //    console.log("ProfitUD3: " + pt);
        //}
        ProfitFA = $('#ProfitFA').val();
        $('#Win3UD').val(Number(w).toFixed(2));
        $('#ProfitUD3').val(Number(pt).toFixed(2));
        $('#Bet3UD').val(Number(b).toFixed(2));
        $('#Payout3UD').val(Number(p).toFixed(2));
        $('#ProfitFA').val(Number(ProfitFA - pt).toFixed(2));
    }

    TotalCost = TotalBetFA + TotalBetUD + parseFloat($('#Bet1UD').val()) + parseFloat($('#Bet2UD').val()) + parseFloat($('#Bet3UD').val());
    console.log("TotalCost: " + TotalCost);
    $('#TotalCost').val(Number(TotalCost).toFixed(2));

    //Leg4
    if ($('#DecOdds4UD').val() != null && $('#DecOdds4UD').val() != "") {
        //ProfitUD4 = Win4UD - TotalCost - Bet1UD - Bet2UD - Bet3UD
        //Payout4UD = Win4UD + Bet4UD
        //Bet4UD = Win4UD / DecOdds4UD
        var w = parseFloat($('#Win3UD').val()) + 14;
        var c = Number($('#TotalCost').val()).toFixed(2);
        //var c2 = Number($('#Bet1UD').val()).toFixed(2);
        //var c3 = Number($('#Bet2UD').val()).toFixed(2);
        //var c4 = Number($('#Bet3UD').val()).toFixed(2);
        c = parseFloat(c);
        var pt = w - c;
        var b = w / $('#DecOdds4UD').val();
        var p = w + b;
        $('#Win4UD').val(Number(w).toFixed(2));
        $('#ProfitUD4').val(Number(pt).toFixed(2));
        $('#Bet4UD').val(Number(b).toFixed(2));
        $('#Payout4UD').val(Number(p).toFixed(2));

        //while (pt < c) {
        //    b += 0.01
        //    w = b * Number($('#DecOdds4UD').val()).toFixed(2)
        //    p = w + b;
        //    pt = w - $('#TotalCost').val();
        //    console.log("Bet4UD: " + b);
        //    console.log("Win4UD: " + w);
        //    console.log("Payout4UD: " + p);
        //    console.log("ProfitUD4: " + pt);
        //}
        ProfitFA = $('#ProfitFA').val();
        $('#Win4UD').val(Number(w).toFixed(2));
        $('#ProfitUD4').val(Number(pt).toFixed(2));
        $('#Bet4UD').val(Number(b).toFixed(2));
        $('#Payout4UD').val(Number(p).toFixed(2));
        $('#ProfitFA').val(Number(ProfitFA - pt).toFixed(2));
    }

    TotalCost = TotalBetFA + TotalBetUD + parseFloat($('#Bet1UD').val()) + parseFloat($('#Bet2UD').val())
        + parseFloat($('#Bet3UD').val()) + parseFloat($('#Bet4UD').val());
    console.log("TotalCost: " + TotalCost);
    $('#TotalCost').val(Number(TotalCost).toFixed(2));
};

function loadTestValues() {
    $('#TotalPayoutFA').val(Number(100).toFixed(2));
    $('#TotalPayoutUD').val(Number(100).toFixed(2));
    $('#Odds1FA').val(Number(-100).toFixed(0));
    $('#Odds1UD').val('+100'); 
    $('#Odds2FA').val(Number(-100).toFixed(0)); 
    $('#Odds2UD').val('+100'); 
    $('#Odds3FA').val(Number(-100).toFixed(0)); 
    $('#Odds3UD').val('+100');  
    $('#Odds4FA').val(Number(-100).toFixed(0)); 
    $('#Odds4UD').val('+100');
};
