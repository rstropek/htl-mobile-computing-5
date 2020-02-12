const express = require("express");
const app = express();

app.get("/api", (req, res, next) => {
    res.json({ "foo": "bar" });
});

const port = process.env.PORT;
app.listen(port, () => {
    console.log(`Server running on port ${port}`);
});
