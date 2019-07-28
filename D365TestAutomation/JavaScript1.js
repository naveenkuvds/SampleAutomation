//Jquery code for clicking on Application button from Hotmail Account
$('button[title="Applications"]').click()

//Click from Applications menu, OneDrive->Excel
$('a[aria-label="Excel"]')[0].click()

// Clicking on blank Excel workbook icon
$('#template_blank').click()

// Code for iterating through all the menu items and clicking on required menuitem. Currently the click even is not getting fired and being worked upon.
for (i = 0; i < document.getElementsByTagName("span").length; i++) {
    if (document.getElementsByTagName("span")[i].innerText === "Data") {

        document.getElementsByTagName("span")[i].click();
        console.log(document.getElementsByTagName("span")[i].innerText);
    }
};

