var myCapacityDetails = [];

function drawPivot() {
    $(function () {
        console.log("aslam", myCapacityDetails);
        $("#PivotOutput").pivotUI(
            myCapacityDetails, {

            rows: ["CostCategory"],
            cols: ["Period"],
            vals: ["Amount"],
            aggregatorName: "Sum"
        }


        )

    });
}


function getPivot() {
    return fetch('./Invoice/GetCapacityData',
        {
            method: 'get',
            headers: {
                'Content-Type': 'application/json;charset=UTF-8'
            }
        })
        .then(function (response) {
            
            if (response.ok) {
                return response.text();

            } else {
                throw Error("Response not OK");
            }
        })
        .then(function (text) {
            try {
                return JSON.parse(text);
            } catch (err) {
                throw Error("Method not found");
            }
        })
        .then(function (responseJSON) {
            
            console.log("aslam", responseJSON);
            myCapacityDetails = responseJSON;
            drawPivot();
        });


}
getPivot();
