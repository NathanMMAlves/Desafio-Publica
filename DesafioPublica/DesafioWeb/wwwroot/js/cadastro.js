class Cadastro {
    static novoCadastro() {
        $('form')[0].reset();
    }

    static pontuacaoFormat(evt) {
        var numero = evt.target.value.replace(/\D/g, "");
        if (numero < 3 || numero > 999) {
            $(evt.target).addClass("invalid");
        } else {
            $(evt.target).removeClass("invalid");
        }
        evt.target.value = numero;
        return numeroPlacar = numero;
    }
}
