<template>
  <div id="app">
    <img src="https://unri.ac.id/wp-content/uploads/2021/03/logo-unri2.png" height="75" widht="300">
    <web-toolbar></web-toolbar>
      <router-view/>
      <web-footer></web-footer>
  </div>
</template>

<script>
import WebFooter from './components/WebFooter'
import WebToolbar from './components/WebToolbar'

export default {
  name: 'App',
  components: {WebFooter,WebToolbar}
}

</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: left;
  color: #2c3e50;
}

nav {
  padding: 30px;

  a {
    font-weight: bold;
    color: #2c3e50;

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
</style>
