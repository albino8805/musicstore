var List = {
    Delete: function (id) {
        var self = this;

        var r = confirm("¿Desea eliminar la categoría?");
        if (r == true) {
            $.ajax({
                url: "/Category/Delete?id=" + id,
                method: 'POST',
                success: function (response) {
                    if (response.Success == 1) {
                        alert(response.Data.Message);
                    } else if (response.Failure == 1) {
                        alert(response.Data.Error);
                    }
                },
                error: function () {
                    alert('Se presentó un error');
                }
            });
        }
    }
};