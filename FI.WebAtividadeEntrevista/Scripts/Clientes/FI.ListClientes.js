
$(document).ready(function () {

    if (document.getElementById("gridClientes"))
        $('#gridClientes').jtable({
            title: 'Clientes',
            paging: true, //Enable paging
            pageSize: 5, //Set page size (default: 10)
            sorting: true, //Enable sorting
            defaultSorting: 'Nome ASC', //Set default sorting
            actions: {
                listAction: urlClienteList,
            },
            fields: {
                Nome: {
                    title: 'Nome',
                    width: '50%'
                },
                Email: {
                    title: 'Email',
                    width: '35%'
                },
                Alterar: {
                    title: '',
                    display: function (data) {
                        return '<button onclick="window.location.href=\'' + urlAlteracao + '/' + data.record.Id + '\'" class="btn btn-primary btn-sm">Alterar</button>';
                    }
                }
            }
        });

    //Load student list from server
    if (document.getElementById("gridClientes"))
        $('#gridClientes').jtable('load');
})



function formatCEP(input) {
    var value = input.value.replace(/\D/g, '');
    var formattedValue = value.padStart(8, '0');
    var formattedCEP = formattedValue.replace(/(\d{5})(\d{3})/, "$1-$2");
    if (formattedCEP === "00000-000") {
        alert("Por favor, insira um CEP valido");

    }
    else {
        input.value = formattedCEP;
    }
}

function formatTel(input) {
    var valorCampo = input.value;
    if (valorCampo.length === 10) {
        input.value = valorCampo.replace(/(\d{2})(\d{4})(\d{4})/, "($1) $2-$3");
    }
    else if (valorCampo.length === 11) {
        input.value = valorCampo.replace(/(\d{2})(\d{5})(\d{4})/, "($1) $2-$3");
    }
    else {
        alert("Telefone inválido. Insira um telefone válido.");
    }
}
