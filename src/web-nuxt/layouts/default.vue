<template>
  <v-app dark>
    <v-app-bar app dense>
    <v-toolbar-title>Tricking Library</v-toolbar-title>
    <v-spacer></v-spacer>
    <v-btn depressed @click="toggleActivity">
      Upload
    </v-btn>
    </v-app-bar>
    <v-main>
      <v-container>
        <nuxt/>
      </v-container>
    </v-main>
    <v-footer
      :absolute="true"
      app
    >
      <span>&copy; {{ new Date().getFullYear() }}</span>
    </v-footer>
  </v-app>
</template>

<script>
  export default {
    data() {
      return {

      }
    },
    methods: {
      toggleActivity(){
        console.log('show/hide dialog');
      }
    }
  }
</script>
