
function submitFilterForm(event) {
    document.getElementById("filterForm").submit();
}

function searchButton() {

    let input = document.getElementById("searchForm");
    let data = document.getElementById("searchData");
    console.log(input);
    console.log(data.value);

    if (data.value != "")
        input.submit();

    //if (input.value != "")
        //window.location.pathname = "/Search/q=" + input.value;
}

function submitSearchForm() {
    let data = document.getElementById("searchData").value;
    console.log(data);
    let hiddenInput = document.getElementById("hiddenSearchData");
    hiddenInput.value = data;
    console.log(document.getElementById("combinedForm"));
    document.getElementById("combinedForm").submit();
}