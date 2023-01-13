/** @type {import('tailwindcss').Config} */
module.exports = {
    purge: {
        enabled: true,
        content: [
            './Pages/**/*.cshtml',
            './Views/**/*.chstml',
        ]
    },
    content: [],
    theme: {
        extend: {},
    },
    plugins: [],
}
