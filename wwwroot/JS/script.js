$("#models").change(function () {
  const change = $("#models option:selected").val()
    $.ajax({
        url: "/home/change?modelsId=" + change,
        method: "get",
        success: function (res) {
            $("#brands option").next().remove() 
            $("#brands").append(res)
        }
    })
});




