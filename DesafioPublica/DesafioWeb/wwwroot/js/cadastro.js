class Cadastro {
    static novoCadastro() {
        $('form')[0].reset();
    }

    static eValidoPlacar(strPlacar) {
        if (strPlacar < 0 || strPlacar > 999) return false;
    }
    static pontuacaoFormat(evt) {
        var numero = evt.target.value.replace(/\D/g, "");
        if (numero < 3 || numero > 999 || !Cadastro.eValidoPlacar(numero)) {
            $(evt.target).addClass("invalid");
        } else {
            $(evt.target).removeClass("invalid");
        }
        evt.target.value = numero;
        return numeroPontuacao = numero;
    }

    static salvarCadastro() {
        if (!Cadastro.formularioCorreto()) {
            alert("Favor verificar as informações preenchidas.");
            return;
        }
        var cadastro = Cadastro.obterValores();
        $('form :input').prop("disabled", true);

        var sucess = (msg) => {
            $('form :input').prop("disabled", false);
            if (msg) {
                alert(msg);
                return;
            }

            alert('Salvo');
            Cadastro.novoCadastro();
        }
        var fail = () => {
            $('form :input').prop("disabled", false);
            alert('Houve um erro no servidor, não foi possível salvar.');
        }

        $.ajax({
            type: "POST",
            url: "Cadastrar",
            data: JSON.stringify(cadastro),
            contentType: "application/json; charset=utf-8",
            dataType: "JSON",

            success: function (output) {
                sucess(output);
            },
            error: function () {
                fail();
            }
        });
    }

    static formularioCorreto() {
        if (!$("#Pontuacao").val() || $("#Pontuacao").hasClass('invalid')) {
            $("#Pontuacao").addClass('invalid');
            return false;
        }
    }
}
