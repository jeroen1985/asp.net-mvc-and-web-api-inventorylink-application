//create generic app
var app = {};

//create an ajax app
app.ajax = {};

//create a tables app
app.tables = {};

//create utilities app 
app.utilities = {};

//create numeric closure utility
app.utilities.numeric = function () {
    var keyEntered = null;
    return {
        setKeyEntered: function (keys) {
            keyEntered = keys;
        },
        forceNumeric: function () {
            if (String.fromCharCode(keyEntered).match(/[^0-9]/g)) {
                return false;
            }
        }
    }
};

// Create an init data table handler
app.tables.init = function () {
    var tableId = null;
    return {
        setTableId:function (id){
            tableId = id;
        },
        init: function () {
            $(tableId).DataTable();
        }
    }
}

//create a generic ajax response method
app.ajax.response = function () {
    var responseIdField = null;
    return {
        setResponseIdField: function(idField){
            responseIdField = idField;
        },
        onSucces: function (response) {
            $(responseIdField).show();
            $(responseIdField).text(response);
            $(responseIdField).delay(2000).fadeOut();
        },
        onFailure: function (){
            alert("Whoops! Something went wrong?");
        }   
    }
}