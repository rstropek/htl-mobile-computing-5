const content = document.getElementById("content");

(async () => {
    const apiResponse = await fetch("/api");
    const apiResult = await apiResponse.json();
    content.innerText = `foo = ${apiResult.foo}`;
})();
