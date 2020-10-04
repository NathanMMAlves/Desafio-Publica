class Placar {
    static pesquisar(pagina) {
        var informacoes = {
            Pagina: pagina || 1
        }
        $('table tbody tr').remove();
        var load = (tb) => {
            var row = $('<tr>');
            var col = $('<td>');
            col.prop("colspan", 10);
            col.append('Carregando...');
            row.append(col);
            tb.append(row);
        };
        load($('table tbody'));
        var carregaLinha = (c, tb, bRG) => {
            var row = $('<tr>');
            const carregaColuna = (v, r) => {
                var col = $('<td>');
                col.append(v);
                r.append(col);
            };

            carregaColuna(c.id, row);
            carregaColuna(c.placar, row);
            carregaColuna(c.minimoDaTemporada, row);
            carregaColuna(c.maximoDaTemporada, row);
            carregaColuna(c.quebraRecordeMin, row);
            carregaColuna(c.quebraRecordeMax, row);

            tb.append(row);
        }

        $.ajax({
            type: "POST",
            url: "Paginar",
            data: JSON.stringify(informacoes),
            contentType: "application/json; charset=utf-8",
            dataType: "JSON",
            success: function (output) {
                Placar.buildPaginador(informacoes.Pagina, output.totalRegistros);
                $('table tbody tr').remove();
                var tb = $('table tbody');
            },
            error: function () {
                $('table tbody tr').remove();
                alert('Falha ao executar pesquisa no servidor.');
            }
        });
    }

    static buildPaginador(pagina, total) {
        const registrosPorPagina = 25;
        var div = $("#paginador");
        div.children().remove();
        var totalDePaginas = Math.ceil(total / registrosPorPagina);
        if (totalDePaginas === 1) return;
        const criarBotao = (p) => {
            var btn = $("<button>");
            btn.text(p);
            btn.click(Placar.pesquisar.bind(Placar, p));
            btn.addClass('btn');
            btn.addClass('btn-pagina');
            return btn;
        }
        var paginas = [1, pagina - 10, pagina - 1, pagina, pagina + 1, pagina + 10, totalDePaginas];
        paginas = paginas.filter((item, pos) => {
            return paginas.indexOf(item) === pos;
        }).filter(item => {
            return item >= 1 && item <= totalDePaginas;
        });
        paginas.forEach(p => {
            var button = criarBotao(p);
            if (p === pagina) button.prop('disabled', true);
            div.append(button);
        });
    }
}

$(document).ready(() => {
    Consulta.pesquisar(1);
})