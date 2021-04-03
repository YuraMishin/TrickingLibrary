<template>
  <v-app dark>
    <v-app-bar app dense>
      <v-toolbar-title>Tricking Library</v-toolbar-title>
      <v-spacer></v-spacer>

      <video-upload/>

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
  import VideoUpload from "../components/video-upload";

  export default {
    components: {VideoUpload}
  }
</script>
