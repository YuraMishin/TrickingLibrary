<template>
  <v-app dark>
    <v-app-bar app dense>
    <v-toolbar-title>Tricking Library</v-toolbar-title>
    <v-spacer></v-spacer>
    <v-btn depressed @click="toggleActivity">
      Upload
    </v-btn>
    </v-app-bar>

    <video-upload/>

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
  import {mapMutations} from 'vuex'
  import VideoUpload from "../components/video-upload";

  export default {
    components: {VideoUpload},
    data() {
      return {

      }
    },
    methods: mapMutations('video-upload', ['toggleActivity'])
  }
</script>
