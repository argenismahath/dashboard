let Btn = document.getElementById("BtnSend");



Btn.addEventListener("click", (e) => {
    console.warn("send data");

    let Name = document.getElementById("Name").value,
        Career = document.getElementById("Career").value,
        Age = document.getElementById("Age").value;

    let data = {
        Name,
        Career,
        Age
    }

    console.log(data);

    fetch('https://localhost:7227/api/User', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify(data)
    })
        .then(response => response.json())
        .then(result => alert("Usuario añadido"))
})