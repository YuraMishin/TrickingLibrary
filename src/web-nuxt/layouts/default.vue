<template>
  <v-app dark>
    <v-app-bar app dense>
      <v-toolbar-title>Tricking Library</v-toolbar-title>
      <v-spacer></v-spacer>

      <content-creation-dialog></content-creation-dialog>

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
  import ContentCreationDialog from "../components/content-creation/content-creation-dialog";

  export default {
    components: {ContentCreationDialog}
  }
</script>
